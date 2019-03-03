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
        private readonly bool @new;

        public AppointmentEdit(bool New)
        {
            InitializeComponent();
            @new = New;
        }

        private void apptEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
