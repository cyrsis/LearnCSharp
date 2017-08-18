using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Sixeyed.Core.Serialization.Serializers
{
    public class BinarySerializer : ISerializer
    {
        public SerializationFormat Format
        {
            get { return SerializationFormat.Binary; }
        }

        public object Deserialize(Type type, object serializedValue)
        {
            object deserialized;
            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream(serializedValue as byte[]))
            {
                 deserialized = formatter.Deserialize(stream);
            }
            return deserialized;
        }

        public object Serialize(object value)
        {
            byte[] serialized;
            var formatter = new BinaryFormatter();
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, value);
                stream.Flush();
                serialized = stream.ToArray();
            }
            return serialized;
        }
    }
}
