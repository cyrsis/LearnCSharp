using System;

namespace ObserverDemo
{
    public class UserInterface
    {
        public readonly IObserver<string> AfterDoSomethingWith;

        public UserInterface()
        {
            this.AfterDoSomethingWith = 
                new NotificationSink<string>(
                    (sender, data) => this.AfterDoSomethingWithHandler(sender, data));
        }

        private void AfterDoSomethingWithHandler(object sender, string data)
        {
            Console.WriteLine("Hey user, look at {0}.", data.ToUpper());
        }
    }
}
