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

            HashSet<MoneyAmount> set = new HashSet<MoneyAmount>();

            set.Add(x);

            if (set.Contains(y))
                Console.WriteLine("Cannot add repeated value.");
            else
                set.Add(y);

            Console.WriteLine("Count = {0}", set.Count);

            Console.ReadLine();
        }
    }
}
