using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLibrary
{
    public class Account
    {
        public string AccountNumber { get; set; }

        public decimal AccountBalance { get; set; }

        public DateTime TransactionDate { get; set; }

        public string UserName { get; set; }

        public int TransactionAmount { get; set; }

        public string TransactionType { get; set; }



    }
}
