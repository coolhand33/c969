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
        private customer custToSave { get; set; }
        private bool newCust = false;

        public CustomerEdit(customer cust)
        {
            InitializeComponent();
            this.custToSave = cust;
            if ( this.custToSave.customerId == 0 )
            {
                custAddLabel.Visible = true;
                custModifyLabel.Visible = false;
                this.newCust = true;
            }
            else
            {
                custAddLabel.Visible = false;
                custModifyLabel.Visible = true;

                int custIdToEdit = int.Parse(cust.customerId.ToString());
                customer customerToEdit = DataAccess.GetCustomer(custIdToEdit);
                custIdBox.Text = customerToEdit.customerId.ToString();
                //addressIdBox.Text = custInfo.Select(c => c.AddressId).ToString();
                //cityIdBox.Text = custInfo.Select(c => c.CityId).ToString();
                //countryIdBox.Text = custInfo.Select(c => c.CountryId).ToString();

                nameBox.Text = customerToEdit.customerName.ToString();
                //phoneBox.Text = custInfo.Select(c => c.Phone).ToString();
                //addressBox.Text = custInfo.Select(c => c.Address1).ToString();
                //address2Box.Text = custInfo.Select(c => c.Address2).ToString();
                //cityBox.Text = custInfo.Select(c => c.City).ToString();
                //postalCodeBox.Text = custInfo.Select(c => c.PostalCode).ToString();
                //countryBox.Text = custInfo.Select(c => c.Country).ToString();
            }
        }

        private void customerSave_Click(object sender, EventArgs e)
        {
            if( this.newCust )
            {
                this.custToSave.customerName = nameBox.Text;
                this.custToSave.active = customerActive.Checked;
                this.custToSave.createdBy = "test";
                this.custToSave.createDate = DateTime.UtcNow;
                this.custToSave.lastUpdate = DateTime.UtcNow;
                this.custToSave.lastUpdateBy = "test";
                this.custToSave.address = GetAddress();
                this.custToSave.address.city = GetCity();
                this.custToSave.address.city.country = GetCountry();
            }
            
            try
            {
                DataAccess.SaveCustomer(this.custToSave);
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
                address1 = addressBox.Text,
                address2 = address2Box.Text,
                postalCode = postalCodeBox.Text,
                phone = phoneBox.Text,
                createdBy = "test",
                createDate = DateTime.UtcNow,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = "test"
            };

            return addr;
        }

        private city GetCity()
        {
            city city = new city
            {
                city1 = cityBox.Text,
                createdBy = "test",
                createDate = DateTime.UtcNow,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = "test"
            };


            return city;
        }

        private country GetCountry()
        {
            country country = new country
            {
                country1 = countryBox.Text,
                createdBy = "test",
                createDate = DateTime.UtcNow,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = "test"
            };

            return country;
        }
    }
}
