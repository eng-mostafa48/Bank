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

namespace Bank.Transactions
{
    public partial class frmDepositWithdraw : Form
    {
        int _AccountID = -1;
        public frmDepositWithdraw()
        {
            InitializeComponent();
        }

        public frmDepositWithdraw(int AccountID)
        {
            InitializeComponent();
            _AccountID = AccountID;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (like backspace)
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmDepositWithdraw_Validating(object sender, CancelEventArgs e)
        {
       
        }

        private void ctrlAccountInfoWithFilter1_OnAccountSelected(int obj)
        {

            clsAccount selectedAccount = clsAccount.FindByAccountID(ctrlAccountInfoWithFilter1.AccountID);

            if (selectedAccount == null)
            {
                MessageBox.Show("Account not found. Please select a valid account.",
                    "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnsave.Enabled = false;
                return;
            }

            if (!selectedAccount.Status)
            {
                MessageBox.Show("Selected account is closed. Please choose another account.",
                    "Account Closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnsave.Enabled = false;
                return;
            }

            btnsave.Enabled = true;
            errorProvider1.Clear();
        }

        private void txtBalance_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBalance.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBalance, "Amount cannot be blank.");
            }
            else if (!double.TryParse(txtBalance.Text, out double amount) || amount <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtBalance, "Amount must be a positive number.");
            }
            else
            {
                errorProvider1.SetError(txtBalance, null);
            }
        }

        private void frmDepositWithdraw_Load(object sender, EventArgs e)
        {
            if(_AccountID != -1)
            {
                ctrlAccountInfoWithFilter1.LoadAccountInfo(_AccountID);
                ctrlAccountInfoWithFilter1.FilterEnabled = false;
                btnsave.Enabled = true ;
            }
            else
            {
                ctrlAccountInfoWithFilter1.FilterEnabled = true;
                btnsave.Enabled = false;
            }

            rbDeposit.Checked = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBalance.Text, out double amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsAccount account = clsAccount.FindByAccountID(ctrlAccountInfoWithFilter1.AccountID);

            if (account == null)
            {
                MessageBox.Show("Selected account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!account.Status)
            {
                MessageBox.Show("Selected account is closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = false;

            if (rbDeposit.Checked)
            {
                result = account.Deposit(amount, clsGlobal.CurrentUser.UserID, txtDescription.Text.Trim());
                ShowResult(result, "Deposit");
            }
            else // Withdraw
            {
                if (account.Balance < amount)
                {
                    MessageBox.Show("Withdrawal amount exceeds account balance.", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                result = account.Withdraw(amount, clsGlobal.CurrentUser.UserID, txtDescription.Text.Trim());
                ShowResult(result, "Withdraw");
            }

            if (result)
            {
                btnsave.Enabled = false;
                ctrlAccountInfoWithFilter1.FilterEnabled = false;
            }
        }

        private void ShowResult(bool success, string action)
        {
            if (success)
            {
                MessageBox.Show($"{action} completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{action} failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
