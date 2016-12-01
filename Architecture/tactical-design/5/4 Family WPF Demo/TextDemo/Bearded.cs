using Common;
using System;

namespace TextDemo
{
    class Bearded : ChainElement, IBearded
    {

        private readonly string owner;

        public Bearded(string owner, ChainElement next) : base(next)
        {
            this.owner = owner;
        }

        public void GrowBeard()
        {
            Console.WriteLine("{0}: beard grows", this.owner);
        }

        public void Shave()
        {
            Console.Write("{0}: shaved", this.owner);
        }

    }
}
