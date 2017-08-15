using System;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            PrintMe(i); // --> PrintMe(int value) static binding

            dynamic d;
            //WriteLine("Create [i]nt or [d]ouble");
            //ConsoleKeyInfo choice = ReadKey(intercept: true);
            //if (choice.Key == ConsoleKey.I)
            //{
            //    d = 99;
            //}
            //else
            //{
            //    d = 55.5;
            //}
            //PrintMe(d);

            d = long.MaxValue;
            PrintMe(d);

            d = "Hello";
            PrintMe(d);


            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }

        static void PrintMe(int value)
        {
            WriteLine($"PrintMe(int) called value: {value}");
        }

        static void PrintMe(long value)
        {
            WriteLine($"PrintMe(long) called value: {value}");
        }

        static void PrintMe(dynamic value)
        {
            WriteLine($"PrintMe(dynamic) called with a {value.GetType()} value: {value}");
        }

        static void PrintMe(object value)
        {
            WriteLine($"PrintMe(object value) = {value}");
        }

    }
}
