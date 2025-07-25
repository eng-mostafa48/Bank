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
    public partial class ctrlPersonCardWithFilter : UserControl
    {

        // Define a custom event handler delegate with parameters
        public event Action<int> OnPersonSelected;

        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int LicenseID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }



        clsPeople _Person;
        int _SelectedPersonID = -1;

        bool _FilterEnabled = true;
        public bool FilterEnabled 
        { set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
            get 
            {
                return _FilterEnabled; 
            }
        }

        public int SelectedPersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPeople SelectedPerson
        {
            get
            {
                return ctrlPersonCard1.SelectedPerson;
            }
        }
        
        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid !", "Validation Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _SelectedPersonID = int.Parse(txtPersonID.Text);
            LoadInfo(_SelectedPersonID);
        }

        public void LoadInfo(int PersonID)
        {
           
            txtPersonID.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
            _SelectedPersonID = ctrlPersonCard1.PersonID;

            if(OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(_SelectedPersonID);

        }

        private void _OnNewPersonAdd(object  sender, int PersonID)
        {
            _SelectedPersonID = PersonID;
            ctrlPersonCard1.LoadPersonInfo(_SelectedPersonID);
        }

        private void txtPersonID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

            if(e.KeyChar == (char)13)
                btnFind.PerformClick();
        }

        private void txtPersonID_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPersonID.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtPersonID, "Person Can not be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtPersonID, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson AddPerson = new frmAddEditPerson();
            AddPerson.DataSend += _OnNewPersonAdd;
            AddPerson.ShowDialog();
        }
    }
}
