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

namespace Bank.Users
{
    public partial class frmAddEditUser : Form
    {
        public enum EnMode { AddNew=0, Update=1};
        EnMode Mode;

        int _UserID = -1;
        clsUser _User;
        public frmAddEditUser()
        {
            InitializeComponent();
            Mode = EnMode.AddNew;
        }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            Mode = EnMode.Update;
        }

        private void _setDefaultValues()
        {
            if (Mode == EnMode.AddNew)
            {
                _User = new clsUser();
                lblTitle.Text = "Add New User";
                this.Text = lblTitle.Text;
                tpUserInfo.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Update User";
                this.Text = lblTitle.Text;

                tpUserInfo.Enabled = true;
                btnSave.Enabled = true;
            }

           
        }

        private void _loadinfo()
        {

            ctrlPersonCardWithFilter1.FilterEnabled = false;


            _User = clsUser.Find(_UserID);


            if (_User == null)
            {
                MessageBox.Show("No User with ID = " + _User, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            txtPassword.Text = _User.Password.ToString();
            txtConfirmPassword.Text = _User.Password.ToString();
            chkIsActive.Checked = _User.IsActive;
            ctrlPersonCardWithFilter1.LoadInfo(_User.PersonID);

        }
      

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = (TextBox)sender;

            if (string.IsNullOrEmpty(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This Field can not be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "This Field can not be blank");
                return;
            }
            else if(txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "does not match Password");
                return;
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Mode == EnMode.Update)
            {
                btnSave.Enabled = true;
                tpUserInfo.Enabled = true;
                tcUser.SelectedTab = tcUser.TabPages["tpUserInfo"];
                return;
            }

            //incase of add new mode.
            if (ctrlPersonCardWithFilter1.SelectedPersonID != -1)
            {

                if (clsUser.IsUserHasPerson(ctrlPersonCardWithFilter1.SelectedPersonID))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }

                else
                {
                    btnSave.Enabled = true;
                    tpUserInfo.Enabled = true;
                    tcUser.SelectedTab = tcUser.TabPages["tpUserInfo"];
                }
            }

            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _setDefaultValues();

            if (Mode == EnMode.Update)
                _loadinfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;


            _User.PersonID = ctrlPersonCardWithFilter1.SelectedPersonID;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.IsActive = chkIsActive.Checked;

            if(_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                Mode = EnMode.Update;
                lblTitle.Text = "Update User";
                this.Text = lblTitle.Text;

                MessageBox.Show("Data Saved Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Save Failed !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
