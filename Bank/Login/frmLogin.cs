using Bank.Global_classes;
using Bank_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Login
{
    public partial class frmLogin : Form
    {
        int _LoginTrial = 0;
        public frmLogin()
        {
            InitializeComponent();


        }

     
        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if(clsGlobal.GetStoredUserNameAndPassword(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                cbRememberMe.Checked = true;
            }

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "UserName Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields Are not Valid, Try again", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUser User = clsUser.Find(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if(User != null)
            {
                if(!User.IsActive)
                {
                    MessageBox.Show("User is not active, Contact Admin", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _LoginTrial++;
                    return;
                }

                if (cbRememberMe.Checked)
                {
                    clsGlobal.RemamberUserNameAndPassWord(txtUserName.Text.Trim(), txtPassword.Text.Trim() );
                }
                else
                {
                    clsGlobal.RemamberUserNameAndPassWord("", "");
                }

                _LoginTrial = 0;
                clsGlobal.CurrentUser = User;
                frmMainScreen MainScreen = new frmMainScreen(this);
                this.Hide();
                MainScreen.ShowDialog();


            }
            else
            {
                _LoginTrial++;

                if (_LoginTrial >= 3)
                {
                    MessageBox.Show(
                               "You have entered the wrong password 3 times.\nAccess has been denied for security reasons.",
                               "Access Denied",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                    this.Close();
                }

                MessageBox.Show("Incorrect UserName or Password", "Credentials Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }


         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
