using Bank.Accounts;
using Bank.Clients;
using Bank.Global_classes;
using Bank.Login;
using Bank.People;
using Bank.Properties;
using Bank.Transactions;
using Bank.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmMainScreen : Form
    {
        frmLogin _Login;
        public enum Gender { Male=1, Female=0 }
        


        bool _sbExpand = true;
        bool _AccSettingsCollaps = true;
        public frmMainScreen(frmLogin login)
        {
            InitializeComponent();
            _Login = login;
        }


        private void sbTimer_Tick(object sender, EventArgs e)
        {
            if (_sbExpand)
            {
                sbPanel.Width -= 10;

                if (sbPanel.Width == sbPanel.MinimumSize.Width)
                {
                   
                    _sbExpand = false;
                    sbTimer.Stop();

                }

            }
            else
            {
                sbPanel.Width += 10;

                if (sbPanel.Width == sbPanel.MaximumSize.Width)
                {

                    _sbExpand = true;
                    sbTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sbTimer.Start();
        }


        private void AccSettingsTimer_Tick(object sender, EventArgs e)
        {
            if (_AccSettingsCollaps)
            {
                AccSettingsPanel.Height += 10;

                if (AccSettingsPanel.Height >= AccSettingsPanel.MaximumSize.Height)
                {
                    AccSettingsPanel.Height = AccSettingsPanel.MaximumSize.Height;
                    _AccSettingsCollaps = false;
                    AccSettingsTimer.Stop();
                }
            }
            else
            {
                AccSettingsPanel.Height -= 10;

                if (AccSettingsPanel.Height <= AccSettingsPanel.MinimumSize.Height)
                {
                    AccSettingsPanel.Height = AccSettingsPanel.MinimumSize.Height;
                    _AccSettingsCollaps = true;
                    AccSettingsTimer.Stop();
                }
            }

        }

        private void btnAccSettings_Click(object sender, EventArgs e)
        {
            AccSettingsTimer.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            _Login.Show();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmListUsers UsersList = new frmListUsers();
            UsersList.ShowDialog();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            frmListPeople frmListPeople = new frmListPeople();
            frmListPeople.ShowDialog();
        }

        private void sbPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo CurrentUserInfo = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            CurrentUserInfo.ShowDialog();
        }

        private void btnChagePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword ChPassForm = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            ChPassForm.ShowDialog();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
 
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmListClients frmListClients = new frmListClients();
            frmListClients.ShowDialog();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            frmListAccounts frmListAccounts = new frmListAccounts();
            frmListAccounts.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmListTransactions frmListTransactions = new frmListTransactions();
            frmListTransactions.ShowDialog();
        }
    }
}
