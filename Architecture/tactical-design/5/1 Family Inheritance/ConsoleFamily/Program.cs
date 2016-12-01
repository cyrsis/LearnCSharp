using System;

namespace ConsoleFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family =
                new Family(
                    new object[] { new Dad(), new Mom(), new Boy(), new Dog() });

            family.WinterBegins();
            family.SummerComes();
            Console.ReadLine();
        }
    }
}
