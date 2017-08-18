using System;
using System.Collections.Generic;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static IEnumerable<int> Xs(int x)
        {
            yield return 42;
            yield return 10 / x;
        }
    }
}
