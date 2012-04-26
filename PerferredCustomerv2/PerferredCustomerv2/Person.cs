using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PerferredCustomerv2
{
    public class Person : ISerializable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }

        public Person(SerializationInfo info, StreamingContext ctxt)
        {
            this.Name = (string)info.GetValue("Name", typeof(string));
            this.Address = (string)info.GetValue("Address", typeof(string));
            this.Number = (string)info.GetValue("Number", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Name", this.Name);
            info.AddValue("Address", this.Address);
            info.AddValue("Number", this.Number);
        }
    }
}
