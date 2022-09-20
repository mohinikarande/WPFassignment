using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ATMLibrary;

namespace WindowsATMFormDemo
{
    public partial class AtmOperation : Form
    {
        UserData datastore;
        string username;
        public string UserName { get => username; set => username=value; }
       
        public AtmOperation()
        {
            InitializeComponent();
            datastore = new UserData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void lblTransaction_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            var acoount = datastore.GetAccountBalance(UserName);
            CheckBalance checkBalance = new CheckBalance();
            
            checkBalance.UserName = acoount.UserName;
            checkBalance.AccountNumber = acoount.AccountNumber;
            checkBalance.Amount = acoount.AccountBalance;

            checkBalance.Show();
            
        }

        private void btnCashWithdraw_Click(object sender, EventArgs e)
        {
            CashWithdraw cashWithdraw = new CashWithdraw();
            cashWithdraw.Show();
        }

        private void btnTransactionStatement_Click(object sender, EventArgs e)
        {
            TransactionStatement transactionStatement = new TransactionStatement();
            transactionStatement.Show();
        }

        private void btnCashDeposite_Click(object sender, EventArgs e)
        {
            CashDeposite cashDeposite = new CashDeposite();
            cashDeposite.Show();
        }
    }
}
