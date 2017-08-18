extern alias APeople;
extern alias BPeople;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Demos.DemoSupportCode;
using NestedClass1 = Demos.DemoSupportCode.Nested.Class1;

namespace Demos
{
    [TestClass]
    public class NamespaceAliasingExample
    {



        [TestMethod]
        public void AliasingTypes()
        {
            var a = new Class1();
            var b = new NestedClass1(); // nested class 1
        }









        [TestMethod]
        public void Extern()
        {           
            var a = new APeople.ConflictingNamespace.Person();
            var b = new BPeople.ConflictingNamespace.Person();
        }



    }
}
