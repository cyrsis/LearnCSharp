using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace members
{
    class DelegateDemo
    {
        public DelegateDemo()
        {
            DebugWindowLogger log1 = new DebugWindowLogger();
            BetterDebugWindowLogger log2 = new BetterDebugWindowLogger();            

            _writer = new WriteMessage(log1.SendMessage);
            _writer += log1.SendMessage;
            _writer += log2.SendMessage;
            _writer += log1.SendMessage;

            _writer = null;

        }

        public void DoWork()
        {
            _writer("Doing some work");
        }

        public WriteMessage _writer;
    }

    
    
    public delegate void WriteMessage(string message);


    public class DebugWindowLogger
    {
        public void SendMessage(string message)
        {
            Debug.WriteLine(message);
        }
    }

    public class BetterDebugWindowLogger
    {
        public void SendMessage(string message)
        {
            Debug.WriteLine(message + " better!");
        }
    }
}
