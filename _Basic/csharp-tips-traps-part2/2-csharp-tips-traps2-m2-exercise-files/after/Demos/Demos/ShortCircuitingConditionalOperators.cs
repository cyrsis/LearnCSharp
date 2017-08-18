using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class ShortCircuitingConditionalOperators
    {        
        [TestMethod]
        public void ShortCircuitConditionalAnd()
        {           
            const string name = "Sarah";

            bool b = false && name == "Sarah";

            b = false && CheckName(name);
            
            b = false & CheckName(name);
        }

        // The conditional-OR operator
        //  || short-circuiting
        //  |  non short-circuiting

        private bool CheckName(string name)
        {
            return name == "Sarah";
        }
    }   
}