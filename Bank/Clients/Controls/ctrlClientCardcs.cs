using Bank_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Clients
{
    public partial class ctrlClientCardcs : UserControl
    {
        int _ClientID = -1;
        clsClient _Client;

        public int ClientID
        {
            get
            {
                return _ClientID;
            }
        }
        public ctrlClientCardcs()
        {
            InitializeComponent();
        }

        public void setDefaultValues()
        {
            ctrlPersonCard1.SetDefaultValues();

            lblClientID.Text = "[???]";
            lblRegDate.Text = "[???]";
        }

        private void _FillClientInfo(int ClientID)
        {
            int PersonID = clsClient.FindByID(ClientID).PersonID;

            ctrlPersonCard1.LoadPersonInfo(PersonID);

            lblClientID.Text = _Client.ClientID.ToString();
            lblRegDate.Text = _Client.reg_Date.ToString();

        }

        public void LoadClientInfo(int ClientID)
        {
            setDefaultValues();

            _ClientID = ClientID;
            _Client = clsClient.FindByID(_ClientID);

            if (_Client == null)
            {
                MessageBox.Show("Client Was not Found !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ClientID = -1;
                return;
            }

            _FillClientInfo(_ClientID);

        }
        

    }
}
