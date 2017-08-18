using System.Collections.Generic;

namespace Demos.DemoSupportCode
{
    public class ByStringLengthComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            return a.Length.CompareTo(b.Length);
        }
    }
}