using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplicationv3
{
    class ObjectToSerialize
    {
        private List<Account> accounts;
        public List<Account> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }

        public ObjectToSerialize()
        {
        }
    }
}
