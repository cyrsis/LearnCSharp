using System;
using ExtraConstraints;

namespace Demo
{
    //public static class BadEnumHelper<T> where T : enum
    //{
    //    public T LastEnumValue()
    //    {
    //        var values = Enum.GetValues(typeof (T));

    //        return (T) values.GetValue(values.Length - 1);
    //    }
    //}

    public class EnumHelper<[EnumConstraint] T>
    {
        public T LastEnumValue()
        {
            var values = Enum.GetValues(typeof (T));

            return (T) values.GetValue(values.Length - 1);
        }
    }
}