using System;
using System.Runtime.Serialization;

namespace BankApplicationv3
{
    [Serializable]
    public class Customer : ISerializable
    {
        private string ssn;

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        private string fName;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        private string lName;

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        private string stAddr;

        public string StAddr
        {
            get { return stAddr; }
            set { stAddr = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        private string zip;

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Customer()
        { 
        }
         public Customer (SerializationInfo info, StreamingContext ctxt)
         {
             this.ssn = (string)info.GetValue("SSN",typeof(string));
             this.fName = (string)info.GetValue("FName",typeof(string));
             this.lName = (string)info.GetValue("LName",typeof(string));
             this.stAddr = (string)info.GetValue("StAddr",typeof(string));
             this.city = (string)info.GetValue("City",typeof(string));
             this.state = (string)info.GetValue("State",typeof(string));
             this.zip = (string)info.GetValue("Zip",typeof(string));
             this.phone = (string)info.GetValue("Phone",typeof(string));
             this.email = (string)info.GetValue("Email",typeof(string));
         }

         public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
         {
             info.AddValue("SSN", this.ssn);
             info.AddValue("FName", this.fName);
             info.AddValue("LName", this.lName);
             info.AddValue("StAddr", this.stAddr);
             info.AddValue("City", this.city);
             info.AddValue("State", this.state);
             info.AddValue("Zip", this.zip);
             info.AddValue("Phone", this.phone);
             info.AddValue("Email", this.email);
         }
    }
}
