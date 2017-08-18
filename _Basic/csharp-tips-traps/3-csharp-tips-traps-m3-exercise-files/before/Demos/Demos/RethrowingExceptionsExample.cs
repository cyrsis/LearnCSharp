using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class RethrowingExceptionsExample
    {
        [TestMethod]
        public void Incorrect()
        {
            var w = new ExceptionRethrowWidget();

            w.NoStacktrace();
        }







        [TestMethod]
        public void Correct()
        {
            var w = new ExceptionRethrowWidget();

            w.WithStacktrace();
        }


    }
}
