using System;
using System.Reflection;

namespace csharp_clr
{
    public interface ILogger
    {
        void LogMessage(String message);
    }

    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
            Console.WriteLine("ConsoleLogger created");
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }


    static class ACtivator
    {
        static void Activate(string[] args)
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetInterface("ILogger") != null)
                {
                    ILogger logger = Activator.CreateInstance(type) as ILogger;
                    logger.LogMessage("Complete!");
                }
            }
        }
    }
}