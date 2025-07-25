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

namespace Bank.People
{
    public partial class frmListPeople : Form
    {
        private DataTable _dtPeople;
        public frmListPeople()
        {
            InitializeComponent();

          
            dgvListPeople.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvListPeople.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvListPeople.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvListPeople.BackgroundColor = Color.White;
            dgvListPeople.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListPeople.EnableHeadersVisualStyles = false;
            dgvListPeople.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvListPeople.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            _dtPeople = clsPeople.GetAllPeople();
            dgvListPeople.DataSource = _dtPeople;
            lblPeopleCount.Text = dgvListPeople.Rows.Count.ToString();

            if (dgvListPeople.Rows.Count > 0)
            {
                dgvListPeople.Columns[0].HeaderText = "Person ID";
                dgvListPeople.Columns[0].Width = 100;

                dgvListPeople.Columns[1].HeaderText = "FullName";
                dgvListPeople.Columns[1].Width = 200;

                dgvListPeople.Columns[2].HeaderText = "Email";
                dgvListPeople.Columns[2].Width = 250;

                dgvListPeople.Columns[3].HeaderText = "Phone";
                dgvListPeople.Columns[3].Width = 100;

                dgvListPeople.Columns[4].HeaderText = "Date Of Birth";
                dgvListPeople.Columns[4].Width = 160;

                dgvListPeople.Columns[5].HeaderText = "Address";
                dgvListPeople.Columns[5].Width = 180;

                dgvListPeople.Columns[6].HeaderText = "Country";
                dgvListPeople.Columns[6].Width = 180;
            }

            cbFilterBy.SelectedIndex = 0;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
      
                txtFilterBy.Visible = (cbFilterBy.Text != "none");
                
            if(txtFilterBy.Visible)
                txtFilterBy.Focus();


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
                case "Email":
                    FilterColumn = "Email";
                    break;
                case "Phone":
                    FilterColumn = "Phone";
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
                _dtPeople.DefaultView.RowFilter = "";
                lblPeopleCount.Text = dgvListPeople.Rows.Count.ToString();
                return;
            }

            
                if(cbFilterBy.Text == "Person ID")
                    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
                else
                    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

                lblPeopleCount.Text = _dtPeople.Rows.Count.ToString();
            

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmAddEditPerson addPerson = new frmAddEditPerson();
            addPerson.ShowDialog();

            frmListPeople_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            frmAddEditPerson addPerson = new frmAddEditPerson(PersonID);
            addPerson.ShowDialog();

            frmListPeople_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want to delete this Person", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            int PersonID = (int)dgvListPeople.CurrentRow.Cells[0].Value;

            if(clsPeople.DeletePerson(PersonID))
            {
                MessageBox.Show("Person Deleted Suuccessfully", "Delete Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmListPeople_Load(null, null);
            }
            else
            {
                MessageBox.Show("Person could not be deleted due to related data.", "Delete Faild",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Not Implemented Yet!", "Feature",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Not Implemented Yet!", "Feature",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmAddEditPerson addPerson = new frmAddEditPerson();
            addPerson.ShowDialog();

            frmListPeople_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvListPeople.CurrentRow.Cells[0].Value;
            frmPersonInfo personInfo = new frmPersonInfo(PersonID);
            personInfo.ShowDialog();

            frmListPeople_Load(null, null);
        }

        private void toolStripSetasClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to add this Person as Client?", "Confirm", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            int PersonID= (int)dgvListPeople.CurrentRow.Cells [0].Value;

            if (clsClient.IsPersonClient(PersonID))
            {
                MessageBox.Show("Person is already a Client", "Error",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                return;

            }


            clsClient client = new clsClient();
            client.PersonID = PersonID;

            if (client.Save())
                MessageBox.Show("Data Saved Successfully", "Confirm",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
                MessageBox.Show("Data Save Failed", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
