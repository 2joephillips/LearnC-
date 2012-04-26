using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Serializer
    {
        public Serializer()
        {
        }

        public void SerializeObject(string fileName, ObjectToSerialize objectToSerialize)
        {
            Stream stream = File.Open(fileName, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
            stream.Close();
        }

        public ObjectToSerialize DeSerializeObject(string filename)
        {
            ObjectToSerialize objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (ObjectToSerialize)bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }
    }
}
