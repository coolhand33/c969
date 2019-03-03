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
    public partial class CustomerEdit : Form
    {
        public CustomerEdit(bool newCust = true)
        {
            InitializeComponent();
            if( newCust)
            {
                custAddLabel.Visible = true;
                custModifyLabel.Visible = false;
            }
        }

        AppointmentsDB.ApptEntities context = new AppointmentsDB.ApptEntities();

        private void customerSave_Click(object sender, EventArgs e)
        {
            string city = customerCity.Text;
            string country = customerCountry.Text;

            AppointmentsDB.customer customer = new AppointmentsDB.customer()
            {
                customerName = customerName.Text
            };
        }
    }
}
