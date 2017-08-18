using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class PartialTypeExample
    {
        [TestMethod]
        public void Example()
        {
            var a = new APartialType();

            a.SomeMethod();
            a.SomeOtherMethod();
        }
    }
}