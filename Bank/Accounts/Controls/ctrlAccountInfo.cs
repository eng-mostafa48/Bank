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

namespace Bank.Accounts.Controls
{
    

    public partial class ctrlAccountInfo : UserControl
    {
        int _AccountID;
        clsAccount _Account;

        clsAccount Account
        {
            get
            {
                return _Account;
            }
        }

        public int AccountID
        {
            get
            {
                return _AccountID;
            }
        }
        public ctrlAccountInfo()
        {
            InitializeComponent();
        }

        private void _SetDefaultValues()
        {
            ctrlPersonCard1.SetDefaultValues();

            lblAccountID.Text = "[???]";
            lblAccountType.Text = "[???]";
            lblBalance.Text = "[???]";
            lblCreatedByUser.Text = "[???]";
            lblCreatedDate.Text = "[???]";
            lblIsActive.Text = "[???]";


        }

        private void _FillAccountInfo(int AccountID)
        {
            int PersonID = clsAccount.FindByAccountID(AccountID).ClientInfo.PersonID;

            ctrlPersonCard1.LoadPersonInfo(PersonID);

            lblAccountID.Text = _Account.AccountID.ToString();
            lblAccountType.Text = clsAccountType.Find(_Account.AccountTypeID).TypeName;
            lblCreatedByUser.Text = clsUser.Find(_Account.CreatedByUserID).UserName;
            lblBalance.Text = _Account.Balance.ToString();
            lblCreatedDate.Text = _Account.CreatedAt.ToString();

            if (_Account.Status)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";


        }

        public void LoadAccountInfo(int AccountID)
        {
            _SetDefaultValues();

            _AccountID = AccountID;
            _Account = clsAccount.FindByAccountID(_AccountID);



            if(_Account == null)
            {
                _AccountID = -1;
                return;
            }

            _FillAccountInfo(_AccountID);

        }
    }
}
