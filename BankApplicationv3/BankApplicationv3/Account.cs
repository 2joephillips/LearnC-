using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BankApplicationv3
{
    [Serializable]
    public class Account : ISerializable
    {
        private int accountId;

        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private decimal rate;

        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        private string maturity;

        public string Maturity
        {
            get { return maturity; }
            set { maturity = value; }
        }
        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public Account()
        {
        }

        public Account(SerializationInfo info, StreamingContext ctxt)
        {
            this.accountId = (int)info.GetValue("AccountId", typeof(int));
            this.type = (string)info.GetValue("Type", typeof(string));
            this.status = (string)info.GetValue("Status", typeof(string));
            this.balance = (decimal)info.GetValue("Balance", typeof(decimal));
            this.rate = (decimal)info.GetValue("Rate", typeof(decimal));
            this.maturity = (string)info.GetValue("Maturity", typeof(string));
            this.customer = (Customer)info.GetValue("Customer", typeof(Customer));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("AccountId", this.accountId);
            info.AddValue("Type", this.type);
            info.AddValue("Status", this.status);
            info.AddValue("Balance", this.balance);
            info.AddValue("Rate", this.rate);
            info.AddValue("Maturity", this.maturity);
            info.AddValue("Customer", this.customer);
        }
    }
}
