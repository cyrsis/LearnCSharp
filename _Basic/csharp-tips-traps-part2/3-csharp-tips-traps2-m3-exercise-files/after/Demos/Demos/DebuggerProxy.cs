using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class DebuggerProxy
    {
        [TestMethod]
        public void Example()
        {
            var p = new Person("Sarah");

            p.Age = 33;                       

            // Add some favourite colours
            p.FavouriteColors.Add(2, "Red");
            p.FavouriteColors.Add(1, "Orange");
            p.FavouriteColors.Add(3, "Pink");
        }
    }
}