using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Generics
{
    class RabbitCollection : ArrayList
    {
        public int Add(Rabbit newRabbit)
        {
            return base.Add(newRabbit);
        }

        public new Rabbit this[int index]
        {
            get { return base[index] as Rabbit; }
            set { base[index] = value; }
        }
    }
}
