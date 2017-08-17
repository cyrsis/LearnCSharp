using System;

namespace Demos.DemoSupportCode
{
    public class NaughtyWordCensorFormatProvider : IFormatProvider, ICustomFormatter
    {
        /// <summary>
        /// Tell the caller what object provides the custom formatting functionality
        /// </summary>        
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof (ICustomFormatter))
            { 
                return this;
            }

            return null;
        }


        /// <summary>
        /// Perform the actual custom formatting
        /// </summary>
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            //return CensorNaughtyWords(arg.ToString());
            
            if (format == "xxx")
            {
                return CensorNaughtyWords(arg.ToString());
            }

            return arg.ToString();
            
        }


        private string CensorNaughtyWords(string s)
        {
            return s.Replace("poopy", "p***y").Replace("darn", "d*rn");
        }
    }
}
