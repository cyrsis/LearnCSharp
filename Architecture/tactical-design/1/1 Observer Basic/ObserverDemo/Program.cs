using System;

namespace ObserverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Doer doer = new Doer();
            doer.Attach(new UserInterface());
            doer.Attach(new Logger());
            doer.DoSomethingWith("my data");
            doer.DoMore("tail");
            Console.ReadLine();
        }
    }
}
