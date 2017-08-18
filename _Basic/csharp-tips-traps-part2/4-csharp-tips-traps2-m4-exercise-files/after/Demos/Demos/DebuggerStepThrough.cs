using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class DebuggerStepThrough
    {
        [TestMethod]
        public void Example()
        {
            var t = new Thing();

            t.Method1();

            var n = t.Name;

            t.Name = "Sarah";
        }
    }
}