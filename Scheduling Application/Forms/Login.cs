using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scheduling_Application.Model;
using System.Threading;

namespace Scheduling_Application
{
    public partial class login : Form
    {
        //login in screen that determins the user's location and translates login along with error messagges in user's language using rsx for additional language which is Russian.
        public login()
        {
            InitializeComponent();

            this.Text = Properties.strings.Login;
            labelLogin.Text = Properties.strings.Login;
            labelUsername.Text = Properties.strings.Name;
            labelPassword.Text = Properties.strings.Password;
            buttonLogin.Text = Properties.strings.Login;
            buttonCancel.Text = Properties.strings.Cancel;
        }

        public string UserName
        {
            get
            {
                return UsernameTbox.Text;
            }
        }
        public string Password
        {
            get
            {
                return PasswordTbox.Text;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (UsernameTbox.Text == "")
            {
                MessageBox.Show(Properties.strings.LoginCannotBeEmpty);
            }
            else if (PasswordTbox.Text == "")
            {
                MessageBox.Show(Properties.strings.PasswordCannotBeEmpty);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
