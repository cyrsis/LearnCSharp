using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.ReadLine();

        const int N = 50000000;

        var als = new ArrayList(N);
        {
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < N; i++)
            {
                als.Add(i); // Hidden boxing cost
            }

            Console.WriteLine(sw.Elapsed);
            sw.Restart();

            long sum = 0L;
            for (int i = 0; i < N; i++)
            {
                sum += (int)als[i]; // Runtime type checking cost
            }

            Console.WriteLine(sw.Elapsed);
        }

        Console.ReadLine();

        var lst = new List<int>(N);
        {
            var sw = Stopwatch.StartNew();

            for (int i = 0; i < N; i++)
            {
                lst.Add(i);
            }

            Console.WriteLine(sw.Elapsed);
            sw.Restart();

            long sum = 0L;
            for (int i = 0; i < N; i++)
            {
                sum += lst[i];
            }

            Console.WriteLine(sw.Elapsed);
        }

        Console.ReadLine();
    }
}
