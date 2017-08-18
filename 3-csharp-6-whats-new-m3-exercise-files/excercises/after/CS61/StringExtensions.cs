using System;

namespace CS61
{
    public static class StringExtensions
    {
        public static bool AreNotSameSymbols(string one, string two)
        {
            return string.Compare(one, two, 
                StringComparison.InvariantCultureIgnoreCase) != 0;
        }

        public static string Format(string template, params object[] args)
        {
            return string.Format(template, args);
        }
    }
}
