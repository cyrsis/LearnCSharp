using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class FormattingColumnsExample
    {
        [TestMethod]
        public void TheHardWay()
        {
            const string name = "Claire";
            const int age = 30;
            const string gender = "female";

            var output = "Name: " + name.PadRight(20) +
                         "Age: " + age.ToString().PadLeft(10) +
                         "Gender: " + gender.PadRight(20);

            Debug.WriteLine(output);
        }











        [TestMethod]
        public void TheEasierWay()
        {
            const string name = "Claire";
            const int age = 30;
            const string gender = "female";

            var output = string.Format("Name: {0,-20}Age: {1,10}Gender: {2,-20}",
                                                        name, age, gender);

            Debug.WriteLine(output);

            // Debug.WriteLine("Name: {0,-20}Age: {1,10}Gender: {2,-20}",
            //                                            name, age, gender);
        }

    }
}
