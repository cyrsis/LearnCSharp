using System.Diagnostics;
using System.Threading;
using MethodTimer;

namespace Demo
{
    public class SomeClass
    {
        //[Time]
        public void DoWork()
        {
            Debug.WriteLine("Starting DoWork");

            Thread.Sleep(2000);
        }
    }
}
