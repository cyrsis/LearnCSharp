using System;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    { 
        static void Main(string[] args)
        {
            int int1 = 5;
            int int2 = 2;

            WriteLine($"Int overload {CommonMath.Add(int1, int2)}");


            double double1 = 20;
            double double2 = 5;

            WriteLine($"Double overload {CommonMath.Add(double1, double2)}");





            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }
  
}
