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

namespace Bank.Accounts.Controls
{
    public partial class ctrlClientAccounts : UserControl
    {
        int _ClientID;
        DataTable _dtClientAccounts;
        public ctrlClientAccounts()
        {
            InitializeComponent();
        }

        public void GetClientAccountsList(int ClientID)
        {
            _ClientID = ClientID;

            _dtClientAccounts = clsAccount.GetAccountsOfClient(_ClientID);
            dgvListClientAccounts.DataSource = _dtClientAccounts;

            if (dgvListClientAccounts.Rows.Count > 0)
            {
                dgvListClientAccounts.Columns[0].HeaderText = "Account ID";
                dgvListClientAccounts.Columns[0].Width = 100;
                
                dgvListClientAccounts.Columns[1].HeaderText = "Client ID";
                dgvListClientAccounts.Columns[1].Width = 100;
               
                dgvListClientAccounts.Columns[2].HeaderText = "Client Name";
                dgvListClientAccounts.Columns[2].Width = 150;
               
                dgvListClientAccounts.Columns[3].HeaderText = "Account Type";
                dgvListClientAccounts.Columns[3].Width = 100;
         
                dgvListClientAccounts.Columns[4].HeaderText = "Balance";
                dgvListClientAccounts.Columns[4].Width = 100;
          
                dgvListClientAccounts.Columns[5].HeaderText = "Created Date";
                dgvListClientAccounts.Columns[5].Width = 140;

                dgvListClientAccounts.Columns[6].HeaderText = "Is Active";
                dgvListClientAccounts.Columns[6].Width = 100;
            }

        }
    }
}
