using Bank_BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bank.Users
{
    public partial class frmListUsers : Form
    {
        DataTable _Usersdt;
        public frmListUsers()
        {
            InitializeComponent();


            dgvListUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvListUsers.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvListUsers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvListUsers.BackgroundColor = Color.White;
            dgvListUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListUsers.EnableHeadersVisualStyles = false;
            dgvListUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvListUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListUsers_Load(object sender, EventArgs e)
        {
            _Usersdt = clsUser.GetAllUsers();
            dgvListUsers.DataSource = _Usersdt;
            lblUsersCount.Text = dgvListUsers.Rows.Count.ToString();

            if(dgvListUsers.Rows.Count > 0)
            {
                dgvListUsers.Columns[0].HeaderText = "User ID";
                dgvListUsers.Columns[0].Width = 100;

                dgvListUsers.Columns[1].HeaderText = "Person ID";
                dgvListUsers.Columns[1].Width = 100;

                dgvListUsers.Columns[2].HeaderText = "FullName";
                dgvListUsers.Columns[2].Width = 250;

                dgvListUsers.Columns[3].HeaderText = "User Name";
                dgvListUsers.Columns[3].Width = 200;

                dgvListUsers.Columns[4].HeaderText = "Is Active";
                dgvListUsers.Columns[4].Width = 100;
            }

            cbFilterBy.Text = "none";
            

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if(cbFilterBy.Text == "Is Active")
            {
                cbIsActive.Visible = true;
                txtFilterBy.Visible = false;
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
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "FullName":
                    FilterColumn = "FullName";
                    break;
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "User Name":
                    FilterColumn = "UserName";
                    break;
                default:
                    FilterColumn = "none";
                    break;
            }

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _Usersdt.DefaultView.RowFilter = "";
                lblUsersCount.Text = _Usersdt.Rows.Count.ToString();
                return;
            }


            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                _Usersdt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                _Usersdt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblUsersCount.Text = _Usersdt.Rows.Count.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "YES":
                    FilterValue = "1";
                    break;
                case "NO":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _Usersdt.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _Usersdt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblUsersCount.Text = _Usersdt.Rows.Count.ToString();
        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;

            frmUserInfo UserInfoForm = new frmUserInfo(UserID);
            UserInfoForm.ShowDialog();


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;

            if (clsUser.DeleteUser(UserID))
            {
                MessageBox.Show("User Deleted Suuccessfully", "Delete Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmListUsers_Load(null, null);
            }
            else
            {
                MessageBox.Show("User could not be deleted due to related data.", "Delete Faild",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAdd = new frmAddEditUser();
            frmAdd.ShowDialog();

            frmListUsers_Load(null, null);
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAdd = new frmAddEditUser();
            frmAdd.ShowDialog();

            frmListUsers_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvListUsers.CurrentRow.Cells[0].Value;

            frmAddEditUser Edit = new frmAddEditUser(UserID);
            Edit.ShowDialog();

            frmListUsers_Load(null, null);

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword ChPassForm = new frmChangePassword((int)dgvListUsers.CurrentRow.Cells[0].Value);
            ChPassForm.ShowDialog();
        }
    }
}
