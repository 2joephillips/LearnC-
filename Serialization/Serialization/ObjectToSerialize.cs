using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace Serialization
{   
    [Serializable]
    public class ObjectToSerialize : ISerializable
    {
        private List<Car> cars;

        public List<Car> Cars
        {
            get { return this.cars; }
            set {this.cars = value;}
        }

        public ObjectToSerialize()
        {
        }

        public ObjectToSerialize(SerializationInfo info, StreamingContext ctxt)
        {
            this.cars = (List<Car>)info.GetValue("Cars", typeof(List<Car>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Cars", this.cars);
        }
    }
}
