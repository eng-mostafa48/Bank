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
    public partial class frmClientAccounts : Form
    {
        int _ClientID;
        public frmClientAccounts(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
        }

        private void frmClientAccounts_Load(object sender, EventArgs e)
        {
            ctrlClientAccounts1.GetClientAccountsList(_ClientID);
            ctrlClientCardcs1.LoadClientInfo(_ClientID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
