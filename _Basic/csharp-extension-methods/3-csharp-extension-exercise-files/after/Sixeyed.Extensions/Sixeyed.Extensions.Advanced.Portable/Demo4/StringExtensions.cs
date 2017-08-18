using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class StringExtensions
    {
        public static string FormatWith(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
    }
}
