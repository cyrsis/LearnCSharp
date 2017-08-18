using Microsoft.Practices.Unity;
using System;

namespace Sixeyed.Disposable.DomainConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Container.Configure();
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

                    case "gc":
                        GC.Collect();
                        break;
                }
            }
        }

        private static void Start()
        {
            var runner = Container.Resolve<IBookFeedRunner>();
            runner.Start();
        }
    }
}