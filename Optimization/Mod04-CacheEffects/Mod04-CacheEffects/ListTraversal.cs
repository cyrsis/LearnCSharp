using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_CacheEffects
{
    class ListTraversal
    {
        private const int LIST_SIZE = 8 * 1024 * 1024; // doesn't fit in cache
        private const int REPETITIONS = 10;

        public static void Measure()
        {
            List();
            LinkedList();
        }

        private static void LinkedList()
        {
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < LIST_SIZE; ++i)
            {
                list.AddLast(i);
            }
            Stopwatch sw = new Stopwatch();
            for (int j = 0; j < REPETITIONS; ++j)
            {
                if (j == 1)
                {
                    sw.Start();
                }

                int sum = 0;
                foreach (var element in list)
                {
                    sum += element;
                }
            }
            Console.WriteLine("Linked List: {0}ms", sw.ElapsedMilliseconds);
        }

        private static void List()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < LIST_SIZE; ++i)
            {
                list.Add(i);
            }
            Stopwatch sw = new Stopwatch();
            for (int j = 0; j < REPETITIONS; ++j)
            {
                if (j == 1)
                {
                    sw.Start();
                }

                int sum = 0;
                foreach (var element in list)
                {
                    sum += element;
                }
            }
            Console.WriteLine("List: {0}ms", sw.ElapsedMilliseconds);
        }
    }
}
