using System.Diagnostics;
using System.Threading;

namespace Demos.DemoSupportCode
{
    public class Report
    {
        public Report()
        {
            Debug.WriteLine("*********** Creating report (default ctor) *********** ");

            ReportName = "Default";

            // Simulate resource intensive object creation
            Thread.Sleep(1000);
        }

        public Report(string reportName)
        {
            Debug.WriteLine("*********** Creating report (reportName ctor) *********** ");

            ReportName = reportName;

            // Simulate resource intensive object creation
            Thread.Sleep(1000);
        }

        public string ReportName { get; set; }

        public void DoSomething()
        {
            Debug.WriteLine("Doing something...");
        }
    }
}