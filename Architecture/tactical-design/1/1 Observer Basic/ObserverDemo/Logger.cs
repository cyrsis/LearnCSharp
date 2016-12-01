using System;

namespace ObserverDemo
{
    public class Logger: IObserver
    {
        public void AfterDoSomethingWith(ISubject sender, string data)
        {
            Console.WriteLine("Writing down {0}.", data.ToUpper());
        }

        public void AfterDoMore(ISubject sender, string completeData, string appendedData)
        {
            Console.WriteLine("Writing down appended {0}.", appendedData.ToUpper());
        }
    }
}
