using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class StringIsNullOrEmptyExample
    {
        [TestMethod]
        public void Example()
        {
            var aString = "    ";

            bool isNullOrEmpty;


            if (string.IsNullOrWhiteSpace(aString))
            {
                isNullOrEmpty = true;
            }
            else
            {
                isNullOrEmpty = false;
            }
        }
    }
}
