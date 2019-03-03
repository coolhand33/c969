using System;
using System.Threading;
using System.Globalization;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if( _Authenticate() )
                {
                    this.Hide();
                    new Main().Show();
                } else
                {
                    throw new LoginException( Properties.Resources.LoginError );
                }
            }
            catch( LoginException le)
            {
                loginError.Text = le.Message;
                loginError.Visible = true;
            }
        }

        private bool _Authenticate()
        {
            bool authStatus = false;
            //IQueryable<AppointmentsDB.user> attemptAuth = dbcontext.users.Where(user => user.userName == loginUsernameText.Text && user.password == loginPasswdText.Text);

            //if(attemptAuth.Count() == 1)
            //{
                authStatus = true;
            //}

            return authStatus;
        }
    }
}
