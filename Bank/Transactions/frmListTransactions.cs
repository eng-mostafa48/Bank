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
    public partial class frmListTransactions : Form
    {
        DataTable _dtTransactions;
        public frmListTransactions()
        {
            InitializeComponent();


            dgvListTransactios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvListTransactios.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvListTransactios.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvListTransactios.BackgroundColor = Color.White;
            dgvListTransactios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListTransactios.EnableHeadersVisualStyles = false;
            dgvListTransactios.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvListTransactios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListTransactions_Load(object sender, EventArgs e)
        {
            _dtTransactions = clsTransaction.GetAllTransactions();
            dgvListTransactios.DataSource = _dtTransactions;
            lblTransactionsCount.Text = dgvListTransactios.Rows.Count.ToString();

            if (dgvListTransactios.Rows.Count > 0)
            {
                dgvListTransactios.Columns[0].HeaderText = "Transaction ID";
                dgvListTransactios.Columns[0].Width = 130;

                dgvListTransactios.Columns[1].HeaderText = "From AccountID";
                dgvListTransactios.Columns[1].Width = 130;

                dgvListTransactios.Columns[2].HeaderText = "To AccountID";
                dgvListTransactios.Columns[2].Width = 110;

                dgvListTransactios.Columns[3].HeaderText = "Transaction Type";
                dgvListTransactios.Columns[3].Width = 140;

                dgvListTransactios.Columns[4].HeaderText = "Amount";
                dgvListTransactios.Columns[4].Width = 100;

                dgvListTransactios.Columns[5].HeaderText = "Description";
                dgvListTransactios.Columns[5].Width = 160;

                dgvListTransactios.Columns[6].HeaderText = "Performed By UserID";
                dgvListTransactios.Columns[6].Width = 130;

                dgvListTransactios.Columns[7].HeaderText = "Transaction Date";
                dgvListTransactios.Columns[6].Width = 150;

            }

            cbFilterBy.SelectedIndex = 0;

        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "TransactionType")
            {
                txtFilterBy.Visible = false;
                cbTransactionType.Visible = true;
                cbTransactionType.SelectedIndex = 0;
                cbTransactionType.Focus();
            }
            else
            {
                txtFilterBy.Visible = (cbFilterBy.Text != "none");
                cbTransactionType.Visible = false;
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }

        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "TransactionTypeID";
            string FilterValue = cbTransactionType.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Deposit":
                    FilterValue = "1";
                    break;
                case "Withdraw":
                    FilterValue = "2";
                    break;
                case "Transfer":
                    FilterValue = "3";
                    break;
            }


            if (FilterValue == "All")
                _dtTransactions.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtTransactions.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblTransactionsCount.Text = _dtTransactions.Rows.Count.ToString();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "TransactionID":
                    FilterColumn = "TransactionID";
                    break;
                case "FromAccountID":
                    FilterColumn = "AccountID";
                    break;
                case "ToAccountID":
                    FilterColumn = "ToAccountID";
                    break;
                default:
                    FilterColumn = "none";
                    break;


            }

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtTransactions.DefaultView.RowFilter = "";
                lblTransactionsCount.Text = _dtTransactions.Rows.Count.ToString();
                return;
            }


           
            _dtTransactions.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());

            lblTransactionsCount.Text = _dtTransactions.Rows.Count.ToString();
        }
    }
}
