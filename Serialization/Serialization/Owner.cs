using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Serialization
{
    [Serializable]
    public class Owner :ISerializable
    {

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Owner()
        {
        }

        public Owner(SerializationInfo info, StreamingContext ctxt)
        {
            this.firstName = (string)info.GetValue("FirstName", typeof(string));
            this.lastName = (string)info.GetValue("LastName", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("FirstName", this.firstName);
            info.AddValue("LastName", this.lastName);
        }

    }
}
