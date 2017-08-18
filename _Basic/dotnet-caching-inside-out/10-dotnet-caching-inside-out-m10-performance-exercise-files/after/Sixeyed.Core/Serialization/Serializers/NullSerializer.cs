using System;

namespace Sixeyed.Core.Serialization
{
    /// <summary>
    /// Null implementaion of <see cref="ISerializer"/>
    /// </summary>
    public class NullSerializer : ISerializer
    {
        public SerializationFormat Format
        {
            get { return SerializationFormat.None; }
        }

        /// <summary>
        /// Returns the given object
        /// </summary>
        /// <param name="type"></param>
        /// <param name="serializedValue"></param>
        /// <returns></returns>
        public object Deserialize(Type type, object serializedValue)
        {
            return serializedValue;
        }

        /// <summary>
        /// Returns the given object
        /// </summary>
        /// <param name="type"></param>
        /// <param name="returnValue"></param>
        /// <returns></returns>
        public object Serialize(Type type, object returnValue)
        {
            return returnValue;
        }
    }
}
