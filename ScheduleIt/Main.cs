using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ApptsDb;
using System.Threading.Tasks;

namespace ScheduleIt
{
    public partial class Main : Form
    {
        private List<Reminder> RemindersCache = new List<Reminder>();

        public Main()
        {
            InitializeComponent();
        }

        private int ActiveTab { get; set; }

        //buttons start
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (ActiveTab)
                {
                    //Appointments
                    case 0:
                        AppointmentEdit apptEdit = new AppointmentEdit();
                        apptEdit.ShowDialog();
                        DialogResult apptEditRes = apptEdit.DialogResult;
                        if( apptEditRes == DialogResult.OK)
                        {
                            _UpdateAppointmentsTbl();
                        }
                        break;
                    //Customers
                    case 1:
                        CustomerEdit custEditForm = new CustomerEdit();
                        custEditForm.ShowDialog();
                        DialogResult custEditRes = custEditForm.DialogResult;
                        if( custEditRes == DialogResult.OK)
                        {
                            _UpdateCustomersTbl();
                        }
                        break;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (ActiveTab)
                {
                    //Appointments
                    case 0:
                        var apptId = _GetSelectedId();
                        DialogResult deleteApptConfirm = MessageBox.Show("Are you sure you want to delete?", "Delete Appointment", MessageBoxButtons.YesNo);
                        if(deleteApptConfirm == DialogResult.Yes)
                        {
                            DataAccess.DeleteAppointment(apptId);
                        }
                        _UpdateAppointmentsTbl();
                        break;
                    //Customers
                    case 1:
                        int custId = _GetSelectedId();
                        DialogResult deleteCustConfirm = MessageBox.Show("Are you sure you want to delete?", "Delete Customer", MessageBoxButtons.YesNo);
                        if(deleteCustConfirm == DialogResult.Yes)
                        {
                            DataAccess.DeleteCustomer(custId);
                        }

                        _UpdateCustomersTbl();
                        break;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (ActiveTab)
                {
                    //Appointments
                    case 0:
                        var apptId = _GetSelectedId();
                        AppointmentEdit apptWin = new AppointmentEdit(apptId);
                        apptWin.ShowDialog();
                        DialogResult apptRes = apptWin.DialogResult;
                        if (apptRes == DialogResult.OK)
                        {
                            _UpdateAppointmentsTbl();
                        }
                        break;
                    //Customers
                    case 1:
                        var custId = _GetSelectedId();
                        CustomerEdit custEditForm = new CustomerEdit(custId);
                        custEditForm.ShowDialog();
                        DialogResult res = custEditForm.DialogResult;
                        if (res == DialogResult.OK)
                        {
                            _UpdateCustomersTbl();
                        }
                        break;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        //end buttons

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = sender as TabControl;
            ActiveTab = tab.SelectedIndex;

            switch (ActiveTab)
            {
                //appointments
                case 0:
                    modifyButton.Visible = true;
                    addButton.Visible = true;
                    deleteButton.Visible = true;
                    try
                    {
                        _UpdateAppointmentsTbl();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                //customers
                case 1:
                    modifyButton.Visible = true;
                    addButton.Visible = true;
                    deleteButton.Visible = true;
                    try
                    {
                        _UpdateCustomersTbl();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    }
                    break;
                //reports
                case 2:
                    modifyButton.Visible = false;
                    addButton.Visible = false;
                    deleteButton.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void _UpdateCustomersTbl()
        {
            List<CustomerDisplay> custs = DataAccess.GetCustomerDisplay();
            customersDataGrid.DataSource = custs;
            customersDataGrid.Columns["Id"].Visible = false;
        }

        private void _UpdateAppointmentsTbl()
        {
            string apptViewOpt = apptViewType.SelectedItem?.ToString() ?? "Month";
            List<AppointmentDisplay> appts = DataAccess.GetAppointmentDisplay(LoggedInUser.UserId, apptViewOpt);
            appointmentGridView.DataSource = appts;
            appointmentGridView.Columns["Id"].Visible = false;
            UpdateRemindersCache();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Select the appointments month view
            if(apptViewType.SelectedIndex == -1)
            {
                apptViewType.SelectedIndex = 0;
            }
        }

        private int _GetSelectedId()
        {
            var grid = ActiveTab == 1 ? customersDataGrid : appointmentGridView;
            try
            {
                int rowIndex = grid.SelectedRows[0].Index;
                DataGridViewRow selectedRow = grid.Rows[rowIndex];

                return int.Parse(selectedRow.Cells["Id"].Value.ToString());
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("You must select an entry first!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                throw;
            }

        }

        private void apptViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _UpdateAppointmentsTbl();
        }

        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            if(RemindersCache.Count > 0)
            {
                Reminder nextReminder = RemindersCache[0];
                DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
                

                if (nextReminder.ReminderTime == now)
                {
                    _ShowReminder(nextReminder.CustomerName, nextReminder.StartTime);
                    RemindersCache.Remove(nextReminder);
                }
            }

            return;
        }

        private async void _ShowReminder(string customerName, DateTime startTime)
        {
            await Task.Run(() => MessageBox.Show($"You have an appointment with {customerName} at {startTime.ToShortTimeString()}", "15 Minute Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information));
            return;
        }

        private async void UpdateRemindersCache()
        {
            await Task.Run(() => 
            {
                List<appointment> appointments = DataAccess.GetUserFutureAppointments(LoggedInUser.UserId);

                try
                {
                    RemindersCache.Clear();

                    foreach (appointment appt in appointments)
                    {
                        // establish 15 minutes before appointment start
                        DateTime reminderTime = appt.start - new TimeSpan(0, 15, 0);
                        DateTime timeNow = DateTime.Now;

                        // if the reminder time has already passed we do not want to setup a reminder
                        if( !(timeNow > reminderTime) )
                        {
                            RemindersCache.Add(new Reminder(appt.appointmentId, reminderTime, appt.customer.customerName, appt.start));

                            RemindersCache.Sort((r1, r2) => r1.ReminderTime.CompareTo(r2.ReminderTime));
                        }
                    }

                    return;
                }
                catch (Exception)
                {
                    return;
                }
            });
        }

        private void _RunReport(int reportId)
        {
            var result = DataAccess.RunReportById(reportId);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = result;

            reportResultsGrid.DataSource = bindingSource;
        }

        private void runReport_Click(object sender, EventArgs e)
        {
            try
            {
                _RunReport(reportList.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No report has been selected!", "Uh Oh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void reportList_SelectedIndexChanged(object sender, EventArgs e)
        {
            runReport.Enabled = true;
        }
    }
}
