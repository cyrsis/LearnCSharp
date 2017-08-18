using System.Linq;
using Sixeyed.Core.Containers;

namespace Sixeyed.Core.Serialization
{
    public static class Serializer
    {
        public static ISerializer GetCurrent(SerializationFormat format)
        {            
            var serializers = Container.GetAll<ISerializer>();
            return (from s in serializers
                    where s.Format == format
                    select s).FirstOrDefault();
        }

        public static ISerializer Json     
        {
            get { return GetCurrent(SerializationFormat.Json); }
        }

        public static ISerializer Xml
        {
            get { return GetCurrent(SerializationFormat.Xml); }
        }
    }
}
