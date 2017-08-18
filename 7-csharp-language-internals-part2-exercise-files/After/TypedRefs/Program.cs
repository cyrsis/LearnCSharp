using System;

namespace TypedRefs
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int x = 42;

            var r = __makeref(x);

            Foo(r);

            int* p = Bar();
            Console.WriteLine("Hello!");
            int y = *p;
        }

        static void Foo(TypedReference r)
        {
            __refvalue(r, int) = 43;

            var t = __reftype(r);

            var o = TypedReference.ToObject(r);
        }

        // This doesn't compile; it'd violate memory safety
        /*
        static TypedReference Bar()
        {
            int x = 42;
        
            return __makeref(x);
        }
        */

        // This does compile and is marked as unsafe
        static unsafe int* Bar()
        {
            int x = 42;

            return &x;
        }
    }
}
