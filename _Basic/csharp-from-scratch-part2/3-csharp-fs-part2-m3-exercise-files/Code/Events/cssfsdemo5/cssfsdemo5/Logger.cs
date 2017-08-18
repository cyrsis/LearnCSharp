using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssfsdemo5
{
    public class Logger
    {
        public void Subscribe(Clock theClock)
        {
            theClock.TimeChanged += new Clock.TimeChangeHandler(NewTime);
        }

        public void NewTime(object theClock, TimeEventArgs e)
        {
            Console.WriteLine("Logging event at {0}:{1}:{2}",
                e.Hour.ToString(),
                e.Minute.ToString(),
                e.Second.ToString());

        }


    }
}
