using System;
using System.Collections.Generic;

namespace ValueObjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyAmount x = new MoneyAmount(2, "USD");
            MoneyAmount y = new MoneyAmount(2, "USD");

            if (x == y)
                Console.WriteLine("Values are equal.");

            if (x != y)
                Console.WriteLine("Values are not equal.");

            Console.ReadLine();
        }
    }
}
