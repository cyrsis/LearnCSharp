using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class DebuggerDisplayAttributeExample
    {
        [TestMethod]
        public void Without()
        {
            var p = new PersonWithoutDebuggerDisplay
                        {
                            AgeInYears = 50,
                            Name = "Sarah"
                        };
        }


        [TestMethod]
        public void With()
        {
            var p = new PersonWithDebuggerDisplay
                        {
                            AgeInYears = 50,
                            Name = "Sarah"
                        };
        }




        // DebuggerDisplay can be applied to:
        //Classes
        //Structs
        //Delegates
        //Enums
        //Fields
        //Properties
        //Assemblies
    }
}