using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeInternalThings;

namespace Demos
{
    [TestClass]
    public class InternalsExample
    {
        [TestMethod]
        public void Example()
        {
            var p = new PersonWithInternals();

            p.Hello();

            p.World();


            var ip = new InternalPerson();
        }
    }
}