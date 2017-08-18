using System;

namespace CS61
{
    public class Check
    {
        public static T ArgNotNull<T>(string name, T value)
        {
            if(value == null)
            {
                throw new ArgumentNullException(name);
            }
            return value;
        }
    }
}
