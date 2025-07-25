using Bank.Transactions;
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
    public partial class frmListAccounts : Form
    {
        DataTable _dtAccounts;
        public frmListAccounts()
        {
            InitializeComponent();

            dgvListAccounts.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvListAccounts.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvListAccounts.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvListAccounts.BackgroundColor = Color.White;
            dgvListAccounts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListAccounts.EnableHeadersVisualStyles = false;
            dgvListAccounts.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvListAccounts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void frmListAccounts_Load(object sender, EventArgs e)
        {
            _dtAccounts = clsAccount.GetAllAccounts();
            dgvListAccounts.DataSource = _dtAccounts;
            lblAccountsCount.Text = dgvListAccounts.Rows.Count.ToString();

            if(dgvListAccounts.Rows.Count > 0)
            {
                dgvListAccounts.Columns[0].HeaderText = "Account ID";
                dgvListAccounts.Columns[0].Width = 100;

                dgvListAccounts.Columns[1].HeaderText = "Client ID";
                dgvListAccounts.Columns[1].Width = 100;

                dgvListAccounts.Columns[2].HeaderText = "Client Name";
                dgvListAccounts.Columns[2].Width = 200;

                dgvListAccounts.Columns[3].HeaderText = "Account Type";
                dgvListAccounts.Columns[3].Width = 150;

                dgvListAccounts.Columns[4].HeaderText = "Balance";
                dgvListAccounts.Columns[4].Width = 150;

                dgvListAccounts.Columns[5].HeaderText = "Created Date";
                dgvListAccounts.Columns[5].Width = 180;

                dgvListAccounts.Columns[6].HeaderText = "Is Active";
                dgvListAccounts.Columns[6].Width = 130;
            }
             
            cbFilterBy.SelectedIndex = 0;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if(cbFilterBy.Text == "Is Active")
            {
                txtFilterBy.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilterBy.Visible = (cbFilterBy.Text != "none");
                cbIsActive.Visible = false;
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }


        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Account ID":
                    FilterColumn = "AccountID";
                    break;
                case "Client ID":
                    FilterColumn = "ClientID";
                    break;
                case "Client Name":
                    FilterColumn = "ClientName";
                    break;
                default:
                    FilterColumn = "none";
                    break;
            }

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAccounts.DefaultView.RowFilter = "";
                dgvListAccounts.Text = _dtAccounts.Rows.Count.ToString();
                return;
            }


            if (cbFilterBy.Text == "Account ID" || cbFilterBy.Text == "Client ID")
                _dtAccounts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text);
            else
                _dtAccounts.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text);

                    lblAccountsCount.Text = _dtAccounts.Rows.Count.ToString();

            
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "Status";
            string FilterValue = cbIsActive.Text;

            switch (cbIsActive.Text)
            {
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0"; 
                    break;
                default:
                    FilterValue = "All";
                    break;

            }

            if (FilterValue == "All")
                _dtAccounts.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAccounts.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblAccountsCount.Text = _dtAccounts.Rows.Count.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Account ID" || cbFilterBy.Text == "Client ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountInfo frmAccInfo = new frmAccountInfo((int)dgvListAccounts.CurrentRow.Cells[0].Value);
            frmAccInfo.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to delete this Account", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;


            int AccountID = (int)dgvListAccounts.CurrentRow.Cells[0].Value;

            if (clsAccount.Delete(AccountID))
            {
                MessageBox.Show("Account Deleted Successfully", "Delete Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmListAccounts_Load(null, null);
            }
            else
            {
                MessageBox.Show("Account could not be deleted due to related data.", "Delete Failed",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAccount frmAddAccount = new frmAddAccount();
            frmAddAccount.ShowDialog();

            frmListAccounts_Load(null, null);

        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAccount frmAddAccount = new frmAddAccount();
            frmAddAccount.ShowDialog();

            frmListAccounts_Load(null, null);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Close this Account", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

         

            if (clsAccount.Close((int)dgvListAccounts.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Account Closed Successfully", "Close Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmListAccounts_Load(null, null);
            }
            else
            {
                MessageBox.Show("Account could not be Closed.", "Close Failed",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsAccount_Opening(object sender, CancelEventArgs e)
        {
            bool IsActive = (bool)dgvListAccounts.CurrentRow.Cells[6].Value;

            closeToolStripMenuItem.Enabled = IsActive;

            depositeWithdrawToolStripMenuItem.Enabled= IsActive;
        }

        private void depositeWithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepositWithdraw frmDepositeWithdraw = new frmDepositWithdraw((int)dgvListAccounts.CurrentRow.Cells[0].Value);
            frmDepositeWithdraw.ShowDialog();

            frmListAccounts_Load(null, null);
        }
    }
}
