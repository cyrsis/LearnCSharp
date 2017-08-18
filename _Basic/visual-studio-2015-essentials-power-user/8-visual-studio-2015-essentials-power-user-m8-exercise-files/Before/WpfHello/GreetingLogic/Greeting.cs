using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingLogic
{
    public class Greeting
    {
        // returns a time-appropriate greeting
        public string GetString()
        {
            string greeting = "Hello";
            int hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                greeting = "Good Morning";
            }
            else if (hour > 18)
            {
                greeting = "Good Evening";
            }
#if DEBUG
            greeting += " (this is the debug build)";
#endif
            return greeting;
        }
    }
}
