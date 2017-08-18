using System;
using System.IO;

namespace Sixeyed.Core.Serialization
{
    /// <summary>
    /// Represents a simple object serializer
    /// </summary>
    public interface ISerializer
    {
        SerializationFormat Format { get; }

        /// <summary>
        /// Deserialize a serialized object
        /// </summary>
        /// <param name="type"></param>
        /// <param name="serializedValue"></param>
        /// <returns></returns>
        object Deserialize(Type type, object serializedValue);

        /// <summary>
        /// Serialize an object
        /// </summary>
        /// <param name="returnValue"></param>
        /// <returns></returns>
        object Serialize(object value);
    }
}
