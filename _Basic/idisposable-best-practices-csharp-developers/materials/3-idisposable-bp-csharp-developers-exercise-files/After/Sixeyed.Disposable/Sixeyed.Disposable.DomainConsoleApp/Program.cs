using Microsoft.Practices.Unity;
using System;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    internal class Program
    {
        private static IBookFeedRunner _Runner;

        private static void Main(string[] args)
        {
            Container.Configure();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("'s' to Start; 'gc' to Garbage Collect; 'x' to Exit");
            var command = "";
            while (command != "x")
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "s":
                        Start();
                        break;

                    case "p":
                        Stop();
                        break;

                    case "gc":
                        GC.Collect();
                        break;
                }
            }
        }

        private static void Start()
        {
            _Runner = Container.Resolve<IBookFeedRunner>();
            _Runner.Start();
        }

        private static void Stop()
        {
            if (_Runner != null && _Runner is IDisposable)
            {
                ((BookFeedRunner)_Runner).Dispose();
                _Runner = null;
            }
        }
    }
}