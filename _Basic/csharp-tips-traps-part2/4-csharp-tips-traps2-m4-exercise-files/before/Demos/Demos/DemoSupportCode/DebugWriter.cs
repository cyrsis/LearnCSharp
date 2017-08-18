using System.Diagnostics;

namespace Demos.DemoSupportCode
{
    class DebugWriter
    {
        public void WriteToDebug<T>(T t)
        {
            Debug.WriteLine(t);
        }


        public void Write<T>(T t) where T : IExtraDebuggable 
        {
            Debug.WriteLine(t.DebugInfo);            
        }
    }
}
