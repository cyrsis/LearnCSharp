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
            //int i = 0;
            //for (;; )
            //{
            //    ++i;
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.Write("Happy Birthday! {0} ", i);

            //    if (i > 10)
            //    {
            //        break;
            //    }
            //}

            for (int i = 0; i < 2000; i++)
            {
                if (i % 100 == 0)
                {
                    Console.Write("Happy Birthday! {0}", i);
                }
            }



            //Console.WriteLine("\nTaDa!!");

            //int age = 35;
            //int newAge = ++age;
            //Console.WriteLine("age: {0}, newAge: {1}", age, newAge);

            //newAge = age++;
            //Console.WriteLine("age: {0}, newAge: {1}", age, newAge);








        }

        
    }
}
