using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Generics
{
    class BalloonCollection : ArrayList
    {
        public int Add(Balloon newBalloon)
        {
            return base.Add(newBalloon);
        }

        public new Balloon this[int index]
        {
            get { return base[index] as Balloon; }
            set { base[index] = value; }
        }


    }
}
