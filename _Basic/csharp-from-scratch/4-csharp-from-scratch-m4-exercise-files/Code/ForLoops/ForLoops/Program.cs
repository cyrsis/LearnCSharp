using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 10; ++i)
            //{
            //    Console.Write("Happy Birthday! ");
            //}

            //Console.WriteLine("\nTaDa!!");

            int age = 35;
            int newAge = ++age;
            Console.WriteLine("age: {0}, newAge: {1}", age, newAge);

            newAge = age++;
            Console.WriteLine("age: {0}, newAge: {1}", age, newAge);








        }

        
    }
}
