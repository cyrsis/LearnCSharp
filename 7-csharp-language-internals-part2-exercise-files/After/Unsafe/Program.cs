using System;

namespace Unsafe
{
    class Program
    {
        static unsafe void Main()
        {
            int x = 42;
            string s = "foo";

            int* p = &x;
            int* q = p - 1;

            *q = unchecked((int)0xDEADDEAD);

            Console.WriteLine(s);
        }
    }
}
