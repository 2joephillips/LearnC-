using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BankApplicationv3
{   
    [Serializable]
    public class ObjectToSerialize: ISerializable
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

        public ObjectToSerialize (SerializationInfo info, StreamingContext ctxt)
        {
            this.accounts = (List<Account>)info.GetValue("Accounts",typeof(List<Account>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Accounts", this.accounts);
        }
    }
}
