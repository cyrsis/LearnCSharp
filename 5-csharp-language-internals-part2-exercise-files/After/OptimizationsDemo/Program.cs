using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Test();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static void Test()
    {
        Bar(0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static void Bar(int x)
    {
        Console.WriteLine(1 / x);
    }
}
