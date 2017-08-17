using System;

namespace TestHelperLib
{
    public static class DateTestHelper
    {
        public static bool DateTimeMinDateMeansNull(DateTime dt)
        {
            return dt == DateTime.MinValue;
        }
    }
}
