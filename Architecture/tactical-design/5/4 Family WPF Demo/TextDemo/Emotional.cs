using Common;
using System;

namespace TextDemo
{
    public class Emotional : ChainElement, IEmotional
    {

        private readonly string owner;
        private readonly string laughingSound;

        public Emotional(string owner, string laughingSound, ChainElement next)
            : base(next)
        {
            this.owner = owner;
            this.laughingSound = laughingSound;
        }

        public void BeHappy()
        {
            Console.WriteLine("{0}: {1}", this.owner, this.laughingSound);
        }

        public void BeContent()
        {
        }
    }
}
