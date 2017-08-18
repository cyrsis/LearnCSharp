using System;

namespace MyLibrary
{
    public static class MyConsole
    {
        public static void Print(__arglist)
        {
            var it = new ArgIterator(__arglist);

            var n = it.GetRemainingCount();

            for (int i = 0; i < n; i++)
            {
                var arg = it.GetNextArg();
                var o = TypedReference.ToObject(arg);

                Console.WriteLine(o);
            }
        }
    }
}
