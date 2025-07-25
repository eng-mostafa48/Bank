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
    public partial class ctrlAccountInfoWithFilter : UserControl
    {
        int _AccountID;

        public int AccountID
        {
            get
            {
                return ctrlAccountInfo1.AccountID;
            }
        }

        bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;

            }
            get
            {
                _FilterEnabled = gbFilter.Enabled;
                return _FilterEnabled;
            }
        }



        // Define a custom event handler delegate with parameters
        public event Action<int> OnAccountSelected;

        // Create a protected method to raise the event with a parameter
        protected virtual void AccountSelected(int LicenseID)
        {
            Action<int> handler = OnAccountSelected;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }

        public ctrlAccountInfoWithFilter()
        {
            InitializeComponent();
        }

        private void txtPersonID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if(e.KeyChar == (char)13)
                btnFind.PerformClick();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _AccountID = int.Parse(txtAccountID.Text);

            ctrlAccountInfo1.LoadAccountInfo(_AccountID);

            if (OnAccountSelected != null)
                OnAccountSelected(AccountID);
            
        }

        public void LoadAccountInfo(int AccountID)
        {
            ctrlAccountInfo1.LoadAccountInfo(AccountID);
            _AccountID = AccountID;
        }
    }
}
