using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsATMFormDemo
{
    public partial class CheckBalance : Form
    {

        public CheckBalance()
        {
            InitializeComponent();
         

        }
         
         
       
        public string UserName { set => lblUserName.Text =  value; }

        
        
       
        public string AccountNumber { set => lblAccountNumber.Text = value; }

        public decimal Amount { set => lblAmount.Text =  value.ToString(); }

    }
}
