
using System.Runtime.Serialization;

namespace Sixeyed.Core.Serialization
{
    public enum SerializationFormat
    {
        /// <summary>
        /// No serialization format set
        /// </summary>
        Null = 0,

        /// <summary>
        /// No serailization to be done
        /// </summary>
        None,

        /// <summary>
        /// JSON serialization
        /// </summary>
        Json,

        /// <summary>
        /// XML serialization 
        /// </summary>
        Xml
    }
}
