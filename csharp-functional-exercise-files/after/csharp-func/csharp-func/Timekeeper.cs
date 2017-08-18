using System;
using System.Diagnostics;

namespace csharp_func
{
    public class Timekeeper
    {
        public TimeSpan Measure(Action action)
        {
            var watch = new Stopwatch();
            watch.Start();
            action();
            return watch.Elapsed;
        }
    }
}