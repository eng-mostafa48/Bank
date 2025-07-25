using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Clients.Controls
{
    public partial class ctrlClientCardWithFilter : UserControl
    {
        int _ClienyID;
        public int ClientID
        {
            get
            {
                return ctrlClientCardcs1.ClientID;
            }
        }
        public ctrlClientCardWithFilter()
        {
            InitializeComponent();
        }

        private void txtClientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled  = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
                btnFind.PerformClick();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not Valid!", "Validation Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ClienyID = int.Parse(txtClientID.Text);
            
            ctrlClientCardcs1.LoadClientInfo(_ClienyID);
        }

        private void txtClientID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientID.Text))
            {
                //e.Cancel = true;
                errorProvider1.SetError(txtClientID, "Person Can not be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(txtClientID, null);
            }
        }
    }
}
