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

        public AppointmentEdit(int apptId = 0)
        {
            InitializeComponent();
            _PopulateCustomerBoxOptions();

            if (apptId == 0)
            {
                addApptLabel.Visible = true;
                modifyApptLabel.Visible = false;
                this.newAppt = true;
                this.Appointment = new appointment();
                customerComboBox.SelectedIndex = -1;
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
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.newAppt)
            {
                this.Appointment.createDate = DateTime.UtcNow;
                this.Appointment.createdBy = GlobalVar.LoggedInUser.Username;
            }

            this.Appointment.customer = DataAccess.GetCustomerById(int.Parse(customerComboBox.SelectedValue.ToString()));
            this.Appointment.contact = contactBox.Text;
            this.Appointment.type = typeBox.Text;
            this.Appointment.title = titleBox.Text;
            this.Appointment.location = locationBox.Text;
            this.Appointment.start = startDate.Value.Date.Add(startTime.Value.TimeOfDay).ToUniversalTime();
            this.Appointment.end = endDate.Value.Date.Add(endTime.Value.TimeOfDay).ToUniversalTime();
            this.Appointment.description = descriptionBox.Text;
            this.Appointment.url = urlBox.Text;
            this.Appointment.userId = GlobalVar.LoggedInUser.UserId;
            this.Appointment.lastUpdate = DateTime.UtcNow;
            this.Appointment.lastUpdateBy = GlobalVar.LoggedInUser.Username;

            DataAccess.SaveAppointment(this.Appointment);
        }
    }
}
