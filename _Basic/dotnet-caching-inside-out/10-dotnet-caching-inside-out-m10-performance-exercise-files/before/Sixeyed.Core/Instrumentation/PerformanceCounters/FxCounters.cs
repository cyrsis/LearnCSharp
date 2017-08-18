using Sixeyed.Core.Configuration;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sixeyed.Core.Instrumentation.PerformanceCounters
{
    public static class FxCounters
    {
        public static PerformanceCounterCategoryMetadata CacheTotal { get; private set; }

        static FxCounters()
        {
            CacheTotal = new PerformanceCounterCategoryMetadata()
            {
                Name = CacheConfiguration.Current.PerformanceCounters.CategoryNamePrefix + " - Totals",
                Description = PerformanceCounterCategoryMetadata.DefaultDescription
            };
        }
    }
}