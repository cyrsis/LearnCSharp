using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class DebuggerBrowsableAttributeExample
    {
        [TestMethod]
        public void Without()
        {
            var p = new PersonWithoutDebuggerBrowsable
                        {
                            AgeInYears = 50,
                            Name = "Sarah",
                            FaveColors = {"Red", "Green", "Blue"}
                        };
        }     


        
        
        [TestMethod]
        public void With()
        {
            var p = new PersonWithDebuggerBrowsable
                        {
                            AgeInYears = 50,
                            Name = "Sarah",
                            FaveColors = {"Red", "Green", "Blue"}
                        };
        }

    }
}