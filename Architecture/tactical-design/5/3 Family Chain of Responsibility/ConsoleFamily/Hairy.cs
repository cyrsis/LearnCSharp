using Family.Common;
using System;

namespace ConsoleFamily
{
    class Hairy : ChainElement, IHairy
    {
        private readonly string owner;

        public Hairy(string owner, IChainElement next)
            : base(next)
        {
            this.owner = owner;
        }

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
