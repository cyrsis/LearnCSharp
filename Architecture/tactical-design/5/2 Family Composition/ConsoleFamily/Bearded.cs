using Family.Common;
using System;

namespace ConsoleFamily
{
    class Bearded: IBearded
    {
        private readonly string owner;

        public Bearded(string owner)
        {
            this.owner = owner;
        }

        public void GrowBeard()
        {
            Console.WriteLine("{0}: beard grows", this.owner);
        }
    }
}
