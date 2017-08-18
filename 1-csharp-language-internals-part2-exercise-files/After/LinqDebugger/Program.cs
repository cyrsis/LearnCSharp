using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDebugger
{
    class Program
    {
        static void Main(string[] args)
        {
            var xs = new[] { 2, 4, 7, 6, 5, 1, 2, 3 };

            var ys = from x in xs
                     where "before where " + x
                     where x % 2 == 0
                     where "before orderby " + x
                     orderby 2 * x / 3 descending
                     where "before select " + x
                     select x + 1;

            foreach (var y in ys)
                Console.WriteLine(y);
        }
    }

    static class EnumerableEx
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, string> debug)
        {
            foreach (var item in source)
            {
                Console.WriteLine(debug(item));
                yield return item;
            }
        }
    }
}
