using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class PreprocessorDirectivesExample
    {
        [TestMethod]
        public void ConditionalExample1()
        {
            string s = null;

# if DEBUG

            s = "debug build";

# elif RELEASE

         s = "release build";

# else

            s = "some other build";

# endif

        }





        [TestMethod]
        public void ConditionalExample2()
        {
            WriteToDebugLogFile("Test");
        }


        private void WriteToDebugLogFile(string message)
        {
# if DEBUG
            // ... debug write code
# endif
        }        








        [TestMethod]
        public void WarningAndErrorsExample()
        {
# warning This is a random warning!

# if DEBUG && RELEASE

    # error Cannot be both a debug and release build at the same time!!

# endif
        }


      

    }
}
