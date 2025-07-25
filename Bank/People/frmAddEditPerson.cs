using Bank.Properties;
using Bank_BLL;
using DVLD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.People
{
    public partial class frmAddEditPerson : Form
    {

        //Delegate To Send PersonID Back 
        public delegate void DataSendHandler(object Sender, int PersonID);
        public event DataSendHandler DataSend;

        public enum EnMode { AddNew=0, Update=1 }
        public enum EnGender { Male = 1, Female = 0 }
        EnMode _Mode = EnMode.AddNew;

        int _PersonID = -1;
        clsPeople _Person;
        public frmAddEditPerson()
        {
            InitializeComponent();
            _Mode = EnMode.AddNew;
        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();
            this._PersonID = PersonID;
            _Mode = EnMode.Update;
        }


        private void _FillCountriesinComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows) 
            {
                cbCountries.Items.Add(row["CountryName"]);
            }
        }

        private void _SetDefaultValues()
        {
            _FillCountriesinComboBox();

            cbCountries.SelectedIndex = cbCountries.FindString("Egypt");
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-18);
            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            dtpDateOfBirth.MinDate = DateTime.Today.AddYears(-100);

            if (_Mode == EnMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                this.Text = lblTitle.Text;
                _Person = new clsPeople();
            }
            else
            {
                lblTitle.Text = "Update Person";
                this.Text = lblTitle.Text;

            }

            rbMale.Checked = true;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_128;
            else
                pbPersonImage.Image = Resources.Female_128;

            llRemove.Visible = false;


        }

        private void _LoadData()
        {
            _Person = clsPeople.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Person Was not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName.ToString();
            txtLastName.Text = _Person.LastName.ToString();
            txtEmail.Text = _Person.Email.ToString();
            txtPhone.Text = _Person.Phone.ToString();
            txtAddress.Text = _Person.Address.ToString();
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            cbCountries.SelectedItem = _Person.CountryInfo.CountryName.ToString();

            if (_Person.Gender == (short)EnGender.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;



            if(_Person.ImagePath !="")
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
            }

            llRemove.Visible = (_Person.ImagePath != "");

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Email cannot be blank");
                return;
            }
            else if (!clsValidation.IsValidEmail(email))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid email format");
                return;
            }
            else
            {
             
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "this Field Can not be blank");
                return;
            }
            else
            {
                
                errorProvider1.SetError(textBox, null);
            }
        }

        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Person.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _SetDefaultValues();

            if (_Mode == EnMode.Update)
                _LoadData();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid Check them Again!", "Validation Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage())
                return;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.CountryID = clsCountry.Find(cbCountries.Text).CountryID;

            if (rbMale.Checked)
                _Person.Gender = (short)EnGender.Male;
            else
                _Person.Gender = (short)EnGender.Female;

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";


            if (_Person.Save())
            {
                _PersonID = _Person.PersonID;
                lblTitle.Text = "Update Person";
                _Mode = EnMode.Update;
                this.Text = lblTitle.Text;
                lblPersonID.Text = _Person.PersonID.ToString();

                //Fire The Event
                DataSend?.Invoke(this, _PersonID);

                MessageBox.Show("Data Saved Successfully", "Confirm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Save Failed", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.Load(selectedFilePath);
                llRemove.Visible = true;
                // ...
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            pbPersonImage.ImageLocation= null;
            llRemove.Visible = false;

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_128;
            else
                pbPersonImage.Image = Resources.Female_128;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_128;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_128;
        }
    }
}
