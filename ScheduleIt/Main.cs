using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ScheduleIt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // on load, load data into datagridviews
        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                //Appointments
                case 0:
                    AppointmentEdit apptWin = new AppointmentEdit(true);
                    apptWin.Show();
                    break;
                //Customers
                case 1:
                    new CustomerEdit(true).ShowDialog();
                    break;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = sender as TabControl;
            
            if (tab.SelectedIndex == 1)
            {
                try
                {
                    Update_Customers_Tbl();
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

        private void Update_Customers_Tbl()
        {
            using (AppointmentsDB.ApptEntities context = new AppointmentsDB.ApptEntities()) {
                var query = from cust in context.customers
                            join add in context.addresses on cust.addressId equals add.addressId
                            join cit in context.cities on add.cityId equals cit.cityId
                            join cou in context.countries on cit.countryId equals cou.countryId
                            orderby cust.customerName ascending
                            select new
                            {
                                Name = cust.customerName,
                                Phone = add.phone,
                                Address1 = add.address1,
                                Address2 = add.address2,
                                City = cit.city1,
                                PostalCode = add.postalCode,
                                Country = cou.country1
                            };

                customersDataGrid.DataSource = query.ToList();
            }
        }
    }
}
