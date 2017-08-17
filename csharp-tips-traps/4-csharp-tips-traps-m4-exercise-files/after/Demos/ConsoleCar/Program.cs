using System;
using SomeOptionalParamThings;

namespace ConsoleCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Car("Blue");

            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
