using Family.Common;
using System;

namespace ConsoleFamily
{
    class Dog: IEmotional
    {
        public void BeHappy()
        {
            Console.WriteLine("tail waiving");
        }
    }
}
