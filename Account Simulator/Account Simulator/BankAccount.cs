using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account_Simulator
{
    class BankAccount
    {
        //Field 
        private decimal _balance;

        //Constructor 
        public BankAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        public decimal Balance
        {
            get { return _balance; }      
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }


    }
}
