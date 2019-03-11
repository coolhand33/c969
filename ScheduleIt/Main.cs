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
using ApptsDb;

namespace ScheduleIt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //buttons start
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
                    CustomerEdit custEditForm = new CustomerEdit();
                    custEditForm.ShowDialog();
                    DialogResult res = custEditForm.DialogResult;
                    if( res == DialogResult.OK)
                    {
                        _UpdateCustomersTbl();
                    }
                    break;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
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
                    int rowIndex = customersDataGrid.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = customersDataGrid.Rows[rowIndex];
                    var custId = int.Parse(selectedRow.Cells["Id"].Value.ToString());
                    DataAccess.DeleteCustomer(custId);
                    _UpdateCustomersTbl();
                    break;
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
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
                    int rowIndex = customersDataGrid.SelectedRows[0].Index;
                    DataGridViewRow selectedRow = customersDataGrid.Rows[rowIndex];
                    var custId = int.Parse(selectedRow.Cells["Id"].Value.ToString());
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
            
            if (tab.SelectedIndex == 1)
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
    }
}
