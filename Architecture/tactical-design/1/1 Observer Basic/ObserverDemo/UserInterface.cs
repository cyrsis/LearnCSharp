using System;

namespace ObserverDemo
{
    public class UserInterface: IObserver
    {
        public void AfterDoSomethingWith(ISubject sender, string data)
        {
            Console.WriteLine("Hey user, look at {0}.", data.ToUpper());
        }

        public void AfterDoMore(ISubject sender, string completeData, string appendedData)
        {
        }
    }
}
