using System;

namespace ObserverDemo
{
    public class Logger
    {

        public readonly IObserver<string> AfterDoSomethingWith;
        public readonly IObserver<Tuple<string, string>> AfterDoMore;

        public Logger()
        {
            this.AfterDoSomethingWith =
                new NotificationSink<string>(
                    (sender, data) => this.AfterDoSomethingWithHandler(sender, data));

            this.AfterDoMore =
                new NotificationSink<Tuple<string, string>>(
                    (sender, data) => this.AfterDoMoreHandler(sender, data));
        }

        private void AfterDoSomethingWithHandler(object sender, string data)
        {
            Console.WriteLine("Writing down {0}.", data.ToUpper());
        }

        private void AfterDoMoreHandler(object sender, Tuple<string, string> data)
        {
            Console.WriteLine("Writing down appended {0}.", data.Item2.ToUpper());
        }
    }
}
