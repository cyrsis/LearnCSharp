using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQueue = new Queue<int>();
            myQueue.Enqueue(100);
            int val = myQueue.Dequeue();
            //Console.WriteLine("val: {0}", val);

            for (int i = 0; i < 50; i++)
            {
                myQueue.Enqueue(i);
            }

            foreach (int i in myQueue)
            {
                Console.Write("{0}, ", i);
            }

            var whichValue = myQueue.Dequeue();
            Console.WriteLine("\nDequeued value: {0}", whichValue);
            whichValue = myQueue.Dequeue();
            Console.WriteLine("\nDequeued value: {0}", whichValue);


        }
    }
}
