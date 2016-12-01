using Family.Common;
using System;

namespace ConsoleFamily
{
    class Dad: IBearded, IEmotional
    {
        public void GrowBeard()
        {
            Console.WriteLine("beard grows");
        }

        public void BeHappy()
        {
            Console.WriteLine("hoho");
        }
    }
}
