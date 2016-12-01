using Family.Common;
using System;
using System.Collections.Generic;

namespace ConsoleFamily
{
    class Family
    {
        private IEnumerable<object> members;

        public Family(IEnumerable<object> members)
        {
            this.members = new List<object>(members);
        }

        public void WinterBegins()
        {
            Console.WriteLine("Winter just came...");
            foreach (object obj in this.members)
            {
                this.GrowHair(obj);
                this.GrowBeard(obj);
            }
            Console.WriteLine(new string('-', 20));
        }

        public void SummerComes()
        {
            Console.WriteLine("Summer is here...");
            foreach (object obj in this.members)
            {
                this.BeHappy(obj);
            }
            Console.WriteLine(new string('-', 20));
        }

        private void BeHappy(object obj)
        {
            IEmotional emotional = obj as IEmotional;
            if (emotional != null)
            {
                Console.Write("{0}: ", obj.GetType().Name);
                emotional.BeHappy();
            }
        }

        private void GrowBeard(object obj)
        {
            IBearded bearded = obj as IBearded;
            if (bearded != null)
            {
                Console.Write("{0}: ", obj.GetType().Name);
                bearded.GrowBeard();
            }
        }

        private void GrowHair(object obj)
        {
            IHairy hairy = obj as IHairy;
            if (hairy != null)
            {
                Console.Write("{0}: ", obj.GetType().Name);
                hairy.GrowHair();
            }
        }
    }
}
