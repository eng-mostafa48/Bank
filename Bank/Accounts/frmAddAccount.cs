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

namespace Bank.Accounts
{
    public partial class frmAddAccount : Form
    {
        clsAccount _Account;
        public frmAddAccount()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(ctrlClientCardWithFilter1.ClientID == -1)
            {
                MessageBox.Show("Please Select a Client", "Select a Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tpAccountInfo.Enabled = true;
            btnSave.Enabled = true;
            tcAccount.SelectedTab = tcAccount.TabPages["tpAccountInfo"];
        }

        private void _FillAccountTypesInComboBox()
        {
            DataTable AccountTypesdt = clsAccountType.GetAllAccountTypes();

            foreach (DataRow dataRow in AccountTypesdt.Rows)
            {
                cbAccountType.Items.Add(dataRow["TypeName"]);
            }
        }


    

        private void txtBalance_Validating(object sender, CancelEventArgs e)
        {
            double minBalance = clsAccountType.Find(cbAccountType.Text).minBalance;

            if(Convert.ToDouble(txtBalance.Text) < minBalance)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBalance, "Minimum Balance For This Account Type is " + minBalance);

            }
            else if(string.IsNullOrEmpty(txtBalance.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBalance, "Balance Can not be Blank" );
            }
            else
            {
                errorProvider1.SetError(txtBalance, null);
            }
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }


        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddAccount_Load_1(object sender, EventArgs e)
        {
            _Account = new clsAccount();


            _FillAccountTypesInComboBox();
            cbAccountType.SelectedIndex = 0;
            chkIsActive.Checked = true;
            btnSave.Enabled = false;
            tpAccountInfo.Enabled = false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int AccountTypeID = clsAccountType.Find(cbAccountType.Text).AccountTypeID;

            if (clsAccount.IsAccountExistForClientWithType(ctrlClientCardWithFilter1.ClientID, AccountTypeID))
            {
                MessageBox.Show("Client Already Has Account With this AccountType", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _Account.ClientID = ctrlClientCardWithFilter1.ClientID;
            _Account.AccountTypeID = AccountTypeID;
            _Account.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _Account.Balance = Convert.ToDouble(txtBalance.Text);
            _Account.CreatedAt = DateTime.Now;
            _Account.Status = chkIsActive.Checked;

            if (_Account.Save())
            {
                lblAccountID.Text = _Account.AccountID.ToString();

                MessageBox.Show("Data Saved Successfully", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Data Save Failed", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
