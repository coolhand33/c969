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

        public CustomerEdit(customer cust)
        {
            InitializeComponent();
            this.Customer = cust;
            if ( this.Customer.customerId == 0 )
            {
                custAddLabel.Visible = true;
                custModifyLabel.Visible = false;
                this.newCust = true;
            }
            else
            {
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
            this.Customer.customerName = nameBox.Text;
            this.Customer.active = customerActive.Checked;
            this.Customer.address = GetAddress();
            this.Customer.address.city = GetCity();
            this.Customer.address.city.country = GetCountry();
            this.Customer.lastUpdateBy = "test";

            if( this.newCust )
            {
                this.Customer.createdBy = "test";
                this.Customer.createDate = DateTime.UtcNow;
                this.Customer.lastUpdate = DateTime.UtcNow;
            }
            else
            {
                this.Customer.lastUpdate = DateTime.UtcNow;
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
            address addr = new address
            {
                addressId = this.Customer.addressId,
                address1 = addressBox.Text,
                address2 = address2Box.Text,
                postalCode = postalCodeBox.Text,
                phone = phoneBox.Text,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = "test",
                cityId = this.Customer.address.cityId
            };

            if ( this.newCust)
            {
                addr.createdBy = "test";
                addr.createDate = DateTime.UtcNow;
            }

            return addr;
        }

        private city GetCity()
        {
            city City = new city
            {
                cityId = this.Customer.address.cityId,
                city1 = cityBox.Text,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = "test",
                countryId = this.Customer.address.city.countryId
            };

            if( this.newCust)
            {
                City.createdBy = "test";
                City.createDate = DateTime.UtcNow;
            }

            return City;
        }

        private country GetCountry()
        {
            country country = new country
            {
                countryId = this.Customer.address.city.countryId,
                country1 = countryBox.Text,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = "test"
            };

            if( this.newCust)
            {
                country.createdBy = "test";
                country.createDate = DateTime.UtcNow;
            }

            return country;
        }
    }
}
