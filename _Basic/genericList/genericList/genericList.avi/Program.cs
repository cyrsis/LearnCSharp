using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // array: type-safe, fixed number of items
            // ArrayList: flexible number of items, not type-safe
            // List<T>: best of both worlds

            {
                int[] scores = new int[] { 89, 91, 95, 75, 92 };
                foreach (var score in scores) Console.WriteLine(score);
                scores[0] = 82;
                //scores[5] = 99;
                Console.WriteLine("--");
                foreach (var score in scores) Console.WriteLine(score);
            }

            {
                ArrayList scores = new ArrayList() { 89, 91, 95, 75, 92 };
                Console.WriteLine("--");
                foreach (var score in scores) Console.WriteLine(score);
                scores.Add(99);
                scores.Add("n/a");
                Console.WriteLine("--");
                foreach (var score in scores) Console.WriteLine(score);
                Console.WriteLine("--");
                foreach (var score in scores)
                {
                    Console.WriteLine("score was {0}, points missed was {1}", score, 100 - (int)score);
                }

            }

            {
                List<int> scores = new List<int>() { 89, 91, 95, 75, 92 };
                Console.WriteLine("--");
                foreach (var score in scores) Console.WriteLine(score);
                scores.Add(99);
                //scores.Add("n/a");
                Console.WriteLine("--");
                foreach (var score in scores) Console.WriteLine(score);
                Console.WriteLine("--");
                foreach (var score in scores)
                {
                    Console.WriteLine("score was {0}, points missed was {1}", score, 100 - (int)score);
                }

            }




            Console.ReadLine();
        }
    }
}
