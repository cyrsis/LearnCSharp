using System;

namespace ObserverDemo
{
    public class Logger
    {
        public void AfterDoSomethingWith(object sender, string data)
        {
            Console.WriteLine("Writing down {0}.", data.ToUpper());
        }

        public void AfterDoMore(object sender, Tuple<string, string> data)
        {
            Console.WriteLine("Writing down appended {0}.", data.Item2.ToUpper());
        }
    }
}
