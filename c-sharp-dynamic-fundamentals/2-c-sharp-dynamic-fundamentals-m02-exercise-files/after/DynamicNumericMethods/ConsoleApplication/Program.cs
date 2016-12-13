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


            WriteLine($"Dynamic version {CommonMathDynamic.Add(int1, int2)}");
            WriteLine($"Dynamic version {CommonMathDynamic.Add(double1, double2)}");

            // string result = CommonMathDynamic.Add(1, 4); // run time error

            WriteLine($"Dynamic with generic version {CommonMathDynamicWithGenerics.Add(int1, int2)}");
            WriteLine($"Dynamic with generic version {CommonMathDynamicWithGenerics.Add(double1, double2)}");

            // string result2 = CommonMathDynamicWithGenerics.Add(1, 4); // compile time error


            short short1 = 1;
            short short2 = 2;

            //WriteLine($"Dynamic with generic version {CommonMathDynamicWithGenerics.Add(short1, short2)}");



            WriteLine($"Dynamic with generic explicit cast version {CommonMathDynamicWithGenericsExplicitCast.Add(short1, short2)}");

            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }
  
}
