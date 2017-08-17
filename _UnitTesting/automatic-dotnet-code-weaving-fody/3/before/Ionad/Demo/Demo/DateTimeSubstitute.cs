using System;
using Ionad;

namespace Demo
{
#if DEBUG
    [StaticReplacement(typeof(DateTime))]
    public static class DateTimeSubstitute
    {
        public static DateTime SubstituteDate;

        public static DateTime Now
        {
            get
            {
                return SubstituteDate;
            }
        }
    } 
#endif
}
