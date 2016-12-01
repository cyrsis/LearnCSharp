using Common;
using System;

namespace TextDemo
{
    public class Hairy : ChainElement, IHairy
    {

        private readonly string owner;

        public Hairy(string owner, ChainElement next) : base(next) 
        {
            this.owner = owner;
        }

        public void GrowHair()
        {
            Console.WriteLine("{0}: hair gets long", this.owner);
        }

        public void CutHair()
        {
            Console.WriteLine("{0}: visited the hair dresser", this.owner);
        }
    }
}
