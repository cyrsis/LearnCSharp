using System;
using System.Threading;

namespace DispatcherExample
{
    public class SlowThing
    {
        public string Data
        {
            get
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));

                return "Hello, world";
            }
        }
    }
}
