using System;
using System.Threading;

namespace DemoCode
{
    public static class LogMessageWriter
    {
        public static void Write(LogMessageEntry message)
        {
            message.MessageSavedTime = DateTime.Now;

            // simulate writing message to log store
            Thread.Sleep(100);            
        }
    }
}