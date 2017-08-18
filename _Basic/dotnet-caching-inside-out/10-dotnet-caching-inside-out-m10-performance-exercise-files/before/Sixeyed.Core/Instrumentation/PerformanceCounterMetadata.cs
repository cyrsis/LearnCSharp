using System.Diagnostics;

namespace Sixeyed.Core.Instrumentation
{
    public class PerformanceCounterMetadata
    {
        public PerformanceCounterCategoryMetadata Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PerformanceCounterType Type { get; set; }

        public string FullName
        {
            get { return string.Format("{0}_{1}", Category.Name, Name); }
        }
    }
}