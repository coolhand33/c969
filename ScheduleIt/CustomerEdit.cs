using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApptsDb;

namespace ScheduleIt
{
    public partial class CustomerEdit : Form
    {
        private customer Customer { get; set; }
        private bool newCust = false;

        public CustomerEdit(int custId = 0)
        {
            InitializeComponent();
            if ( custId == 0 )
            {
                custAddLabel.Visible = true;
                custModifyLabel.Visible = false;
                this.newCust = true;
                this.Customer = new customer();
            }
            else
            {
                this.Customer = DataAccess.GetCustomerById(custId);
                custAddLabel.Visible = false;
                custModifyLabel.Visible = true;

                customerActive.Checked = this.Customer.active;
                nameBox.Text = this.Customer.customerName;
                phoneBox.Text = this.Customer.address.phone;
                addressBox.Text = this.Customer.address.address1;
                address2Box.Text = this.Customer.address.address2;
                cityBox.Text = this.Customer.address.city.city1;
                postalCodeBox.Text = this.Customer.address.postalCode;
                countryBox.Text = this.Customer.address.city.country.country1;
            }
        }

        private void customerSave_Click(object sender, EventArgs e)
        {
            //Customer info
            if ( this.newCust )
            {
                this.Customer.createdBy = "test";
                this.Customer.createDate = DateTime.UtcNow;
            }
            this.Customer.customerName = nameBox.Text;
            this.Customer.active = customerActive.Checked;
            this.Customer.lastUpdateBy = "test";
            this.Customer.lastUpdate = DateTime.UtcNow;

            //Address info
            if( this.newCust)
            {
                this.Customer.address = GetAddress();
                this.Customer.address.city = GetCity();
                this.Customer.address.city.country = GetCountry();
            }
            else
            {
                this.Customer.address.address1 = addressBox.Text;
                this.Customer.address.address2 = address2Box.Text;
                this.Customer.address.postalCode = postalCodeBox.Text;
                this.Customer.address.phone = phoneBox.Text;
                this.Customer.address.lastUpdate = DateTime.UtcNow;
                this.Customer.address.lastUpdateBy = "test";
            }

            
            try
            {
                DataAccess.SaveCustomer(this.Customer);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private address GetAddress()
        {
            return new address
            {
                address1 = addressBox.Text,
                address2 = address2Box.Text,
                postalCode = postalCodeBox.Text,
                phone = phoneBox.Text,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = "test",
                createdBy = "test",
                createDate = DateTime.UtcNow
            };
        }

        private city GetCity()
        {
            return new city
            {
                city1 = cityBox.Text,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = "test",
                createdBy = "test",
                createDate = DateTime.UtcNow
            };

        }

        private country GetCountry()
        {
            return new country
            {
                country1 = countryBox.Text,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = "test",
                createdBy = "test",
                createDate = DateTime.UtcNow
            };

        }
    }
}
