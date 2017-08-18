using System.Diagnostics;
using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class StaticConstructorExceptions
    {
        
        [TestMethod]
        public void Example()
        {
            try
            {
                // Make static ctor execute
                var greeting = ClassWithStaticCtorException.Greeting;
            }
            catch
            {
                Debug.WriteLine("Static ctor exception occurred");
            }

            var c = new ClassWithStaticCtorException();
        }

    }   
}