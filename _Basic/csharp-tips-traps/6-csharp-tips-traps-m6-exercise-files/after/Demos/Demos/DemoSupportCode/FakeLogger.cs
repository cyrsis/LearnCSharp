using System.Diagnostics;

namespace Demos.DemoSupportCode
{
    class FakeLogger
    {
        [Conditional("LOG")]
        public void WriteLogMessage(string message)
        {
            Debug.WriteLine("DEBUG MESSAGE: " + message);
        }
    }
}
