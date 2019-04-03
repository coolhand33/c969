using ApptsDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleIt
{
    public partial class AppointmentEdit : Form
    {
        appointment Appointment { get; set; }
        bool newAppt { get; set; }
        List<appointment> cacheAppointments { get; set; }

        public AppointmentEdit(int apptId = 0)
        {
            InitializeComponent();
            _PopulateCustomerBoxOptions();

            //getting a list of appointments to check against for overlapping appts
            this.cacheAppointments = DataAccess.GetUserAppointments(LoggedInUser.UserId);

            if (apptId == 0)
            {
                addApptLabel.Visible = true;
                modifyApptLabel.Visible = false;
                this.newAppt = true;
                this.Appointment = new appointment();
                customerComboBox.SelectedIndex = -1;
                startDate.Value = DateTime.Now;
                endDate.Value = DateTime.Now;
            }
            else
            {
                this.Appointment = DataAccess.GetAppointmentById(apptId);
                addApptLabel.Visible = false;
                modifyApptLabel.Visible = true;
                customerComboBox.SelectedIndex = customerComboBox.FindStringExact(this.Appointment.customer.customerName);
                contactBox.Text = this.Appointment.contact;
                typeBox.Text = this.Appointment.type;
                titleBox.Text = this.Appointment.title;
                locationBox.Text = this.Appointment.location;
                startDate.Value = this.Appointment.start.ToLocalTime();
                startTime.Value = this.Appointment.start.ToLocalTime();
                endDate.Value = this.Appointment.end.ToLocalTime();
                endTime.Value = this.Appointment.end.ToLocalTime();
                descriptionBox.Text = this.Appointment.description;
                urlBox.Text = this.Appointment.url;

                //since this is a modify we need to remove this appointment from cacheAppointments to allow for proper validation
                //using a lambda here because it simplifies the code without making it unreadable.
                appointment apptToRemove = this.cacheAppointments.Single(a => a.appointmentId == apptId);
                this.cacheAppointments.Remove(apptToRemove);
            }
        }

        private void apptEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _PopulateCustomerBoxOptions()
        {
            customerComboBox.DataSource = new List<string>();
            List<customer> customers = DataAccess.GetCustomers();

            customerComboBox.DataSource = customers;
            customerComboBox.DisplayMember = "customerName";
            customerComboBox.ValueMember = "customerId";

            //fill in autocomplete
            var autoComplete = new AutoCompleteStringCollection();
            foreach(customer customer in customers)
            {
                autoComplete.Add(customer.customerName);
            }
            customerComboBox.AutoCompleteCustomSource = autoComplete;
        }

        private void newCustomer_Click(object sender, EventArgs e)
        {
            CustomerEdit custEditForm = new CustomerEdit();
            custEditForm.ShowDialog();
            DialogResult custEditRes = custEditForm.DialogResult;
            if (custEditRes == DialogResult.OK)
            {
                _PopulateCustomerBoxOptions();
                customerComboBox.SelectedIndex = customerComboBox.Items.Count - 1;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!scheduleVerify())
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            if (this.newAppt)
            {
                this.Appointment.createDate = DateTime.UtcNow;
                this.Appointment.createdBy = LoggedInUser.Username;
            }

            this.Appointment.customer = DataAccess.GetCustomerById(int.Parse(customerComboBox.SelectedValue.ToString()));
            this.Appointment.contact = contactBox.Text;
            this.Appointment.type = typeBox.Text;
            this.Appointment.title = titleBox.Text;
            this.Appointment.location = locationBox.Text;
            this.Appointment.start = startDate.Value.Date.Add(startTime.Value.TimeOfDay).ToUniversalTime();
            this.Appointment.end = endDate.Value.Date.Add(endTime.Value.TimeOfDay).ToUniversalTime();
            //resetting seconds to 0 so reminders are accurate
            this.Appointment.start = this.Appointment.start.AddSeconds(-this.Appointment.start.Second);
            this.Appointment.end = this.Appointment.end.AddSeconds(-this.Appointment.end.Second);
            this.Appointment.description = descriptionBox.Text;
            this.Appointment.url = urlBox.Text;
            this.Appointment.userId = LoggedInUser.UserId;
            this.Appointment.lastUpdateBy = LoggedInUser.Username;
            this.Appointment.lastUpdate = DateTime.UtcNow;

            DataAccess.SaveAppointment(this.Appointment);

            
        }

        private bool scheduleVerify()
        {
            scheduleErrorBox.Visible = false;

            try
            { 
                //establish local business hours 8AM - 5PM Local
                DateTime businessStartTime = new DateTime(this.Appointment.start.Year, this.Appointment.start.Month, this.Appointment.start.Day, 8, 0, 0);
                DateTime businessEndTime = new DateTime(this.Appointment.end.Year, this.Appointment.end.Month, this.Appointment.end.Day, 17, 0, 1); ;
                
                this.Appointment.start = startDate.Value.Date.Add(startTime.Value.TimeOfDay);
                this.Appointment.end = endDate.Value.Date.Add(endTime.Value.TimeOfDay);

                //check for inside business hours
                if (this.Appointment.start < businessStartTime || this.Appointment.end > businessEndTime || (this.Appointment.end - this.Appointment.start).TotalHours > 9)
                {
                    throw new ScheduleException("Appointment outside the 8AM - 5PM hours of operation");
                }

                //start can't be later than the end
                if(this.Appointment.start > this.Appointment.end)
                {
                    throw new ScheduleException("Start date is later than the End date.");
                }

                //loop over all appointments checking for overlapping, or existing appointments, throw the proper exceptions.
                foreach (appointment appt in this.cacheAppointments)
                {
                    //check for overlapping appt
                    if((this.Appointment.start > appt.start && this.Appointment.start < appt.end) || (this.Appointment.end < appt.end && this.Appointment.end > appt.start))
                    {
                        throw new ScheduleException("You already have an appointment scheduled at this time");
                    }
                }

                return true;
            }
            catch (ScheduleException schedEx)
            {
                scheduleErrorBox.Text = schedEx.Message;
                scheduleErrorBox.Visible = true;
                return false;
            }
        }

        private void startDate_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
