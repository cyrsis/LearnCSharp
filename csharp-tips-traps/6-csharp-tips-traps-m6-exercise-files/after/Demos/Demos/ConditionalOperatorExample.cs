using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class ConditionalOperatorExample
    {

        [TestMethod]
        public void SimpleUsage()
        {
            var name = "Sarah";
            string estimatedGender;


            if (name == "Sarah")
            {
                estimatedGender = "female";
            }
            else
            {
                estimatedGender = "male";
            }

            estimatedGender = name == "Sarah" ? "female" : "male";

            name = "John";

            estimatedGender = name == "Sarah" ? "female" : "male";
        }







        [TestMethod]
        public void Readability()
        {
            var name = "Sarah";
            string estimatedGender;
            
            estimatedGender = name == "Sarah" ? "female" : "male";

            estimatedGender = (name == "Sarah") ? "female" : "male";

            estimatedGender = (name == "Mary")
                                  ? "female"
                                  : (name == "Sarah")
                                        ? "female"
                                        : "male";

            name = "John";

            estimatedGender = (name == "Mary")
                                  ? "female"
                                  : (name == "Sarah")
                                        ? "female"
                                        : "male";
        }







        [TestMethod]
        public void ControlFlow()
        {
            var name = "Sarah";

            // this will not compile:
            //(name == "Sarah") ? Debug.WriteLine("female") : Debug.WriteLine("male");
        }
    }
}
