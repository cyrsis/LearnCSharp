using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeTrials();

            UseTheMagicHat();

            MagicHat<Rabbit> hat = CreateHat<Rabbit>();
            hat.Fill();
            hat.Dissapear();

            Console.ReadLine();
        }

        private static MagicHat<T> CreateHat<T>() where T:class, IAmMagical, new()
        {
            Type hatType = typeof(MagicHat<>);
            return Activator.CreateInstance(hatType.MakeGenericType(typeof(T)))
                as MagicHat<T>;
        }

        private static void UseTheMagicHat()
        {
            MagicHat<Rabbit> hat = new MagicHat<Rabbit>();
            hat.Put(new Rabbit { Name = "Fluffy" });
            hat.Put(new Rabbit { Name = "Muffy" });

            Rabbit firstRabbit = hat.Pull();
            Console.WriteLine(firstRabbit.Name);
        }

        private static void TimeTrials()
        {
            long arrayListTime = CalculateSumOnArrayList();
            long listTime = CalculateSumOnListOfInt();

            Console.WriteLine("ArrayList took {0}ms, List<int> took {1}ms", 
                                arrayListTime, listTime);
        }

        private static long CalculateSumOnListOfInt()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            List<int> list = new List<int>();
            for (int i = 0; i < ITERATIONS; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                int value = list[i];
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        private static long CalculateSumOnArrayList()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            ArrayList list = new ArrayList();
            for (int i = 0; i < ITERATIONS; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < list.Count; i++)
            {
                int value = (int)list[i];
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;        
        }

        static int ITERATIONS = 10000000;
    }
}
