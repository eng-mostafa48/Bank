using Bank.People;
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

namespace Bank.Clients
{
    public partial class frmListClients : Form
    {
        DataTable _dtClients;
        public frmListClients()
        {
            InitializeComponent();


            dgvListClients.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvListClients.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvListClients.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvListClients.BackgroundColor = Color.White;
            dgvListClients.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListClients.EnableHeadersVisualStyles = false;
            dgvListClients.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvListClients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void frmListClients_Load(object sender, EventArgs e)
        {
            _dtClients = clsClient.GetAllClients();
            dgvListClients.DataSource = _dtClients;
            lblPeopleCount.Text = dgvListClients.Rows.Count.ToString();
            cbFilterBy.SelectedIndex = 0;

            if(dgvListClients.Rows.Count > 0)
            {
                dgvListClients.Columns[0].HeaderText = "Client ID";
                dgvListClients.Columns[0].Width = 100;

                dgvListClients.Columns[1].HeaderText = "Person ID";
                dgvListClients.Columns[1].Width = 100;

                dgvListClients.Columns[2].HeaderText = "FullName";
                dgvListClients.Columns[2].Width = 200;

                dgvListClients.Columns[3].HeaderText = "Email";
                dgvListClients.Columns[3].Width = 250;

                dgvListClients.Columns[4].HeaderText = "Address";
                dgvListClients.Columns[4].Width = 200;

                dgvListClients.Columns[5].HeaderText = "Country";
                dgvListClients.Columns[5].Width = 150;

            }

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "Client ID" ||  cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = (cbFilterBy.Text != "none");

            if (txtFilterBy.Visible)
                txtFilterBy.Focus();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";


            switch (cbFilterBy.Text)
            {
                case "Client ID":
                    FilterColumn = "ClientID";
                    break;
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "FullName":
                    FilterColumn = "FullName";
                    break;
                case "Email":
                    FilterColumn = "Email";
                    break;
                case "Address":
                    FilterColumn = "Address";
                    break;
                case "Country":
                    FilterColumn = "CountryName";
                    break;
                default:
                    FilterColumn = "none";
                    break;
            }

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtClients.DefaultView.RowFilter = "";
                lblPeopleCount.Text = dgvListClients.Rows.Count.ToString();
                return;
            }


            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "Client ID")
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                _dtClients.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblPeopleCount.Text = _dtClients.Rows.Count.ToString();
        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to delete this Client", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;


            int ClientID = (int)dgvListClients.CurrentRow.Cells[0].Value;

            if (clsClient.DeleteClient(ClientID))
            {
                MessageBox.Show("Client Deleted Successfully", "Delete Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmListClients_Load(null, null);
            }
            else
            {
                MessageBox.Show("Client could not be deleted due to related data.", "Delete Failed",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showClientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientInfo ClientInfo = new frmClientInfo((int)dgvListClients.CurrentRow.Cells[0].Value);
            ClientInfo.ShowDialog();
        }

        private void showClientAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientAccounts frmClientAccs = new frmClientAccounts((int)dgvListClients.CurrentRow.Cells[0].Value);
            frmClientAccs.ShowDialog();
        }
    }
}
