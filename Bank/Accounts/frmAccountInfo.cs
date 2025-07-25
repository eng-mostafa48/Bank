using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Accounts
{
    public partial class frmAccountInfo : Form
    {
        int _AccountID;
        public frmAccountInfo(int AccountID)
        {
            InitializeComponent();
            _AccountID = AccountID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccountInfo_Load(object sender, EventArgs e)
        {
            ctrlAccountInfo1.LoadAccountInfo(_AccountID);
        }
    }
}
