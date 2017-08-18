using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Advanced.Demo1
{
    public static class InstrumentationExtensions
    {
        private static Dictionary<Guid, Stopwatch> _Stopwatches = new Dictionary<Guid, Stopwatch>();
        public static double GetPreciseElapsedTime(this Instrumentation instrumentation)
        {
            var fieldInfo = typeof(Instrumentation).GetField("_startedAt", BindingFlags.Instance | BindingFlags.NonPublic);
            var startedAt = (DateTime)fieldInfo.GetValue(instrumentation);
            return new TimeSpan(DateTime.Now.Ticks - startedAt.Ticks).TotalSeconds;
        }

        public static void StartWithPrecision(this Instrumentation instrumentation)
        {
            _Stopwatches[instrumentation.Id] = Stopwatch.StartNew();
        }

        public static long GetReallyPreciseElapsedTime(this Instrumentation instrumentation)
        {
            return _Stopwatches[instrumentation.Id].ElapsedMilliseconds;
        }
    }
}
