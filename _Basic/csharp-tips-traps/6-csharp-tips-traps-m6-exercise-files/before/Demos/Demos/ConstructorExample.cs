using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class ConstructorExample
    {      
        [TestMethod]
        public void CreatePerson()
        {
            var p1 = new Person("Sarah");

            var p2 = new Person("Gentry", 22);

            var p3 = new Person("Anna", 42);
        }
    }
}
