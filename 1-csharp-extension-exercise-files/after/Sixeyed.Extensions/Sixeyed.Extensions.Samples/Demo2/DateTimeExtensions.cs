using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace System
{
    public static class DateTimeExtensions
    {

        public static string ToXmlDateTime(this DateTime dateTime, 
            XmlDateTimeSerializationMode mode = XmlDateTimeSerializationMode.Utc)
        {
            return XmlConvert.ToString(dateTime, mode);
        }
    }
}
