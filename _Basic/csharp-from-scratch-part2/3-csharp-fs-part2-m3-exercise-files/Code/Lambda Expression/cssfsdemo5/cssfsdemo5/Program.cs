using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssfsdemo5
{
    class Program
    {
        static void Main(string[] args)
        {
            var theClock = new Clock();
            var visibleClock = new VisibleClock();
            visibleClock.Subscribe(theClock);
            var logger = new Logger();
            logger.Subscribe(theClock);
            theClock.RunClock();

        }
    }
}
