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

namespace Bank.Users.Controls
{
    public partial class ctrlUserInfo : UserControl
    {
        int _UserID = -1;
        clsUser _User;

        public ctrlUserInfo()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _UserID = UserID;
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("User wac not Found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName.ToString();
            lblISActive.Text = _User.IsActive ? "YES" : "NO";
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
        }
    }
}
