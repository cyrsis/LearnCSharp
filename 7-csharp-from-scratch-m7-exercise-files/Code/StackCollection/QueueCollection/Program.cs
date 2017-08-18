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
            var myStack = new Stack<int>();
            myStack.Push(100);
            int val = myStack.Pop();
            Console.WriteLine("val: {0}", val);

            for (int i = 0; i < 50; i++)
            {
                myStack.Push(i);
            }

            foreach (int i in myStack)
            {
                Console.Write("{0}, ", i);
            }

            var whichValue = myStack.Pop();
            Console.WriteLine("\nPopped value: {0}", whichValue);
            whichValue = myStack.Pop();
            Console.WriteLine("\nPopped value: {0}", whichValue);


        }
    }
}
