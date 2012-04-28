using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplicationv3
{
    public class Account
    {
        private int accountId;
        private string type;
        private string status;
        private decimal balance;
        private decimal rate;
        private DateTime maturity;
        private Customer customer;

        public Account()
        {
        }
    }
}
