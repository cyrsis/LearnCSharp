using System;
using System.Xml;

namespace Sixeyed.Extensions.Advanced.Demo3
{
    public static class DateTimeExtensions
    {
        public static string ToXmlDateTime(this DateTime dateTime)
        {
            return XmlConvert.ToString(dateTime, XmlDateTimeSerializationMode.Utc);
        }
    }
}
