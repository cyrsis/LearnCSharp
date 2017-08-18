using System.Diagnostics;

namespace Demos.DemoSupportCode
{
    class FakeLogger
    {
        
        public void WriteLogMessage(string message)
        {
            Debug.WriteLine("DEBUG MESSAGE: " + message);
        }
    }
}
