using Family.Common;
using System;

namespace ConsoleFamily
{
    class Hairy : IHairy
    {
        private readonly string owner;

        public Hairy(string owner)
        {
            this.owner = owner;
        }

        public void GrowHair()
        {
            Console.WriteLine("{0}: hair gets long", this.owner);
        }
    }
}
