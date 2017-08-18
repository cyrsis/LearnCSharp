using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class HidingInterfaceImplementations
    {
        
        [TestMethod]
        public void Example()
        {
            var byClass = new SomeClass();

            byClass.MethodA();
            // byClass.MethodB();    // Compile error - cannot access MethodB()


            var byInterface = (ISomeInterface) byClass;

            byInterface.MethodA();
            byInterface.MethodB();
        }
    }   
}