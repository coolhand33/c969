using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApptsDb;

namespace ScheduleIt
{
    public partial class CustomerEdit : Form
    {
        private customer Customer { get; set; }
        private bool newCust = false;
        private ErrorProvider nameErrorProvider;
        private ErrorProvider phoneErrorProvider;
        private ErrorProvider addressErrorProvider;
        private ErrorProvider address2ErrorProvider;
        private ErrorProvider cityErrorProvider;
        private ErrorProvider postalCodeErrorProvider;
        private ErrorProvider countryErrorProvider;

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

            //errorProvider Setup
            nameErrorProvider = new ErrorProvider();
            nameErrorProvider.SetIconAlignment(this.nameBox, ErrorIconAlignment.MiddleRight);
            nameErrorProvider.SetIconPadding(this.nameBox, 2);
            nameErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            phoneErrorProvider = new ErrorProvider();
            phoneErrorProvider.SetIconAlignment(this.phoneBox, ErrorIconAlignment.MiddleRight);
            phoneErrorProvider.SetIconPadding(this.phoneBox, 2);
            phoneErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            addressErrorProvider = new ErrorProvider();
            addressErrorProvider.SetIconAlignment(this.addressBox, ErrorIconAlignment.MiddleRight);
            addressErrorProvider.SetIconPadding(this.addressBox, 2);
            addressErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            address2ErrorProvider = new ErrorProvider();
            address2ErrorProvider.SetIconAlignment(this.address2Box, ErrorIconAlignment.MiddleRight);
            address2ErrorProvider.SetIconPadding(this.address2Box, 2);
            address2ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            cityErrorProvider = new ErrorProvider();
            cityErrorProvider.SetIconAlignment(this.cityBox, ErrorIconAlignment.MiddleRight);
            cityErrorProvider.SetIconPadding(this.cityBox, 2);
            cityErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            postalCodeErrorProvider = new ErrorProvider();
            postalCodeErrorProvider.SetIconAlignment(this.postalCodeBox, ErrorIconAlignment.MiddleRight);
            postalCodeErrorProvider.SetIconPadding(this.postalCodeBox, 2);
            postalCodeErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            countryErrorProvider = new ErrorProvider();
            countryErrorProvider.SetIconAlignment(this.countryBox, ErrorIconAlignment.MiddleRight);
            countryErrorProvider.SetIconPadding(this.countryBox, 2);
            countryErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void customerSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                //Customer info
                if (this.newCust)
                {
                    this.Customer.createdBy = LoggedInUser.Username;
                    this.Customer.createDate = DateTime.UtcNow;
                }
                this.Customer.customerName = nameBox.Text;
                this.Customer.active = customerActive.Checked;
                this.Customer.lastUpdateBy = LoggedInUser.Username;
                this.Customer.lastUpdate = DateTime.UtcNow;

                //Address info
                if (this.newCust)
                {
                    this.Customer.address = GetNewAddress();
                    this.Customer.address.city = GetNewCity();
                    this.Customer.address.city.country = GetNewCountry();
                }
                else
                {
                    this.Customer.address.address1 = addressBox.Text;
                    this.Customer.address.address2 = address2Box.Text;
                    this.Customer.address.postalCode = postalCodeBox.Text;
                    this.Customer.address.phone = phoneBox.Text;
                    this.Customer.address.lastUpdate = DateTime.UtcNow;
                    this.Customer.address.lastUpdateBy = LoggedInUser.Username;
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
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private address GetNewAddress()
        {
            return new address
            {
                address1 = addressBox.Text,
                address2 = address2Box.Text,
                postalCode = postalCodeBox.Text,
                phone = phoneBox.Text,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = LoggedInUser.Username,
                createdBy = "test",
                createDate = DateTime.UtcNow
            };
        }

        private city GetNewCity()
        {
            return new city
            {
                city1 = cityBox.Text,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = LoggedInUser.Username,
                createdBy = LoggedInUser.Username,
                createDate = DateTime.UtcNow
            };

        }

        private country GetNewCountry()
        {
            return new country
            {
                country1 = countryBox.Text,
                lastUpdate = DateTime.UtcNow,
                lastUpdateBy = LoggedInUser.Username,
                createdBy = LoggedInUser.Username,
                createDate = DateTime.UtcNow
            };

        }

        private bool ValidateRequired(string input, Control control, out string errorMsg)
        {
            if(input.Trim().Length == 0)
            {
                errorMsg = "This field is required";
                nameErrorProvider.SetError(control, errorMsg);
                return false;
            }

            errorMsg = "";
            nameErrorProvider.SetError(control, String.Empty);
            return true;
        }

        private void ValidatePhone()
        {
            string regexPattern = "^(?:[0-9] ?){6,14}[0-9]$";
            if(!Regex.IsMatch(phoneBox.Text, regexPattern))
            {
                throw new InvalidPhoneException("Phone number format is invalid! Only use numbers, must be at least 7 digits");
            }
        }

        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if( !ValidateRequired(nameBox.Text, nameBox, out errMsg) )
            {
                e.Cancel = true;
            }
        }

        private void phoneBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string errMsg;
                if(!ValidateRequired(phoneBox.Text, phoneBox, out errMsg))
                {
                    e.Cancel = true;
                }
                else
                {
                    ValidatePhone();
                }
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show(ex.Message, "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addressBox_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (!ValidateRequired(addressBox.Text, addressBox, out errMsg))
            {
                e.Cancel = true;
            }
        }

        private void cityBox_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (!ValidateRequired(cityBox.Text, cityBox, out errMsg))
            {
                e.Cancel = true;
            }
        }

        private void postalCodeBox_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (!ValidateRequired(postalCodeBox.Text, postalCodeBox, out errMsg))
            {
                e.Cancel = true;
            }
        }

        private void countryBox_Validating(object sender, CancelEventArgs e)
        {
            string errMsg;
            if (!ValidateRequired(countryBox.Text, countryBox, out errMsg))
            {
                e.Cancel = true;
            }
        }

        private void customerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
