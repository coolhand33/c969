using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity;
using MySql.Data;
using MySql.Data.MySqlClient;
using ApptsDb;

namespace ScheduleIt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private int ActiveTab { get; set; }

        //buttons start
        private void addButton_Click(object sender, EventArgs e)
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

        private void deleteButton_Click(object sender, EventArgs e)
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

        private void modifyButton_Click(object sender, EventArgs e)
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
                        _UpdateCustomersTbl();
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
        //end buttons

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = sender as TabControl;
            ActiveTab = tab.SelectedIndex;
            
            if (ActiveTab == 1)
            {
                try
                {
                    _UpdateCustomersTbl();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
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
            List<AppointmentDisplay> appts = DataAccess.GetAppointmentDisplay(GlobalVar.LoggedInUser.UserId);
            appointmentGridView.DataSource = appts;
            appointmentGridView.Columns["Id"].Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            _UpdateAppointmentsTbl();
        }

        private int _GetSelectedId()
        {
            var grid = ActiveTab == 1 ? customersDataGrid : appointmentGridView;
            int rowIndex = grid.SelectedRows[0].Index;
            DataGridViewRow selectedRow = grid.Rows[rowIndex];

            return int.Parse(selectedRow.Cells["Id"].Value.ToString());
        }
    }
}
