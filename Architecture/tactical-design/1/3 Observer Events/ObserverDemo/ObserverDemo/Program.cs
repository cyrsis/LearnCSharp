using System;

namespace ObserverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Doer doer = new Doer();

            UserInterface userInterface = new UserInterface();
            Logger logger = new Logger();

            doer.AfterDoSomethingWith += userInterface.AfterDoSomethingWith;
            doer.AfterDoSomethingWith += logger.AfterDoSomethingWith;

            doer.AfterDoMore += logger.AfterDoMore;

            doer.DoSomethingWith("my data");
            doer.DoMore("tail");
            
            Console.ReadLine();
        
        }
    }
}
