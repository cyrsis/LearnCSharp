using System;

namespace DemoCode
{
    public class LogMessageEntry
    {
        public string Message { get; private set; }        
        public DateTime MessageSavedTime { get; set; }

        public LogMessageEntry(string message)
        {            
            Message = message;
        }
    }
}