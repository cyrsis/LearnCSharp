using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sixeyed.CarValet.Services.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToExpiresString(this DateTime dateTime)
        {
           return dateTime.ToString("ddd, dd MMM yyyy HH:mm:ss 'GMT'");
        }
    }
}