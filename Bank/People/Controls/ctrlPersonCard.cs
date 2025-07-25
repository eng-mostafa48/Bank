using Bank.Properties;
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
    public partial class ctrlPersonCard : UserControl
    {
        public enum EnGender { Male=1, Female=0}

        int _PersonID = -1;
        clsPeople _Person;

        public int PersonID { get {return _PersonID;}}
        public clsPeople SelectedPerson { get { return _Person; } }
        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void SetDefaultValues()
        {
            lblPersonID.Text = "[???]";
            lblFullName.Text = "[???]";
            lblEmail.Text = "[???]";
            lblPhone.Text = "[???]";
            lblGender.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblCountry.Text = "[???]";
            lblAddress.Text = "[???]";

            pbPersonImage.Image = Resources.Male_128;
        }
        private void _FillPersonInfo()
        {
            lblPersonID.Text = _Person.PersonID.ToString();
            lblFullName.Text = _Person.FullName;
            lblEmail.Text = _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = _Person.CountryInfo.CountryName;

            if(_Person.Gender == (short)EnGender.Male)
            {
                pbGender.Image = Resources.Male_32;
                pbPersonImage.Image = Resources.Male_128;
                lblGender.Text = "Male";
            }
            else
            {
                pbGender.Image = Resources.Female_32;
                pbPersonImage.Image = Resources.Female_128;
                lblGender.Text = "Female";
            }



            if(_Person.ImagePath != "")
                pbPersonImage.ImageLocation = _Person.ImagePath;
        }

        public void LoadPersonInfo(int personID)
        {
            SetDefaultValues();

            _PersonID = personID;
            _Person = clsPeople.Find(_PersonID);

            if (_Person == null) 
            { 
                MessageBox.Show("Person Was not Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _PersonID = -1;
                return;
            }

            _FillPersonInfo();
        }

        private void _OnDataSend(object Sender, int PersonID)
        {
            LoadPersonInfo(PersonID);
        }
        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
                frmAddEditPerson editPerson = new frmAddEditPerson(PersonID);
                editPerson.DataSend += _OnDataSend;
                editPerson.ShowDialog();
          
        }

      
    }
}
