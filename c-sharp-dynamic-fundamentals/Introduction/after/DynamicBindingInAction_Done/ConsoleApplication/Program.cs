using System;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputTimeStaticBinding();

            OutputTimeDynamicBinding();

            OutputTimeDynamicBindingRunTimeError();

            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }

        private static void OutputTimeStaticBinding()
        {
            DateTime dt = DateTime.Now;

            string time = dt.ToLongTimeString();

            WriteLine(time);
        }

        private static void OutputTimeDynamicBinding()
        {
            dynamic dt = DateTime.Now;

            string time = dt.ToLongTimeString();

            WriteLine(time);
        }

        private static void OutputTimeDynamicBindingRunTimeError()
        {
            dynamic dt = DateTime.Now;

            string time = dt.IsItCoffeeTime();

            WriteLine(time);
        }
    }
}
