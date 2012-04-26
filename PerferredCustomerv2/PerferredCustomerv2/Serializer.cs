using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PerferredCustomerv2
{
    class Serializer
    {
        public Serializer()
        {
        }

        public void SerializeObject(string filename, ObjectToSerialize objectToSerialize)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
        }

        public ObjectToSerialize DeserializeObject(string filename)
        {
            ObjectToSerialize objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();
            objectToSerialize = (ObjectToSerialize)bformatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }
    }
    [Serializable()]
    public class ObjectToSerialize: ISerializable
	{
		private List<PerferredCustomer> customers;

        public List<PerferredCustomer> Customers
        {
            get { return this.customers;}
            set { this.customers = value;}
        }

        public ObjectToSerialize()
        {
        }

        public ObjectToSerialize(SerializationInfo info, StreamingContext ctxt)
        {
            this.customers = (List<PerferredCustomer>)info.GetValue("PerferredCustomer", typeof(List<PerferredCustomer>));
        }

        public void GetOjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("PerferredCustomer", this.customers);
        }
	}
}
