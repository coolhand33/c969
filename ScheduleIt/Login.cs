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
using ApptsDb;

namespace ScheduleIt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = loginButton;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if( _Authenticate() )
                {
                    this.Hide();
                    new Main().Show();
                }
                else
                {
                    throw new LoginException(Properties.Resources.LoginError);
                }
            }
            catch( LoginException le)
            {
                loginError.Text = le.Message;
                loginError.Visible = true;
            }

            loginButton.Enabled = true;
        }

        private bool _Authenticate()
        {
            loginButton.Enabled = false;
            bool authStatus = false;
            loginError.Visible = false;

            using (apptsEntities context = new apptsEntities())
            {
                //I prefer the look and style of linq lambdas. They reduce the amount of code necessary to query the db
                var user = context.users
                    .Where(u => u.userName == loginUsernameBox.Text)
                    .Where(u => u.password == loginPasswordBox.Text)
                    .FirstOrDefault();

                if (user != null)
                {
                    authStatus = true;
                    LoggedInUser.UserId = user.userId;
                    LoggedInUser.Username = user.userName;
                }
            }


            return authStatus;
        }
    }
}
