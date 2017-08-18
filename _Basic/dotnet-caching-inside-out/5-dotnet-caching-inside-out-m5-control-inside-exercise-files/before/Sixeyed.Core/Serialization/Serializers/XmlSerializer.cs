using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Sixeyed.Core.Serialization
{
    /// <summary>
    /// XML implementaion of <see cref="ISerializer"/>
    /// </summary>
    public class XmlSerializer : ISerializer
    {
        public SerializationFormat Format
        {
            get { return SerializationFormat.Xml; }
        }

        /// <summary>
        /// Returns the given object
        /// </summary>
        /// <param name="type"></param>
        /// <param name="serializedValue"></param>
        /// <returns></returns>
        public object Deserialize(Type type, object serializedValue)
        {
            object obj;
            var data = Encoding.UTF8.GetBytes(serializedValue.ToString());
            using (var stream = new MemoryStream(data))
            {
                var serializer = new DataContractSerializer(type);
                obj = serializer.ReadObject(stream);
            }            
            return obj;
        }

        /// <summary>
        /// Returns the given object
        /// </summary>
        /// <param name="returnValue"></param>
        /// <returns></returns>
        public object Serialize(object value)
        {
            using (var stream = new MemoryStream())
            {
                var serializer = new DataContractSerializer(value.GetType());
                serializer.WriteObject(stream, value);
                stream.Flush();
                var serializedValue = Encoding.UTF8.GetString(stream.GetBuffer(), 0, (int)stream.Length);
                return serializedValue;
            }
        }
    }
}
