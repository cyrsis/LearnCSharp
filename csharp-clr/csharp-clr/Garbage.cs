using System;
using System.Collections.Generic;

namespace csharp_clr
{
    public class Garbage
    {
        static void DoIt()
        {
            for (int i = 0; i < 100000; i++)
            {
                _employees.Add(new Employee() { Name = i.ToString() });

                if (i % 10000 == 0)
                {
                    Console.WriteLine(GetTotalCollections());
                }
            }

            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }

        static int GetTotalCollections()
        {
            return GC.CollectionCount(0) +
                   GC.CollectionCount(1) +
                   GC.CollectionCount(2);
        }

        static List<Employee> _employees = new List<Employee>();

    }
}