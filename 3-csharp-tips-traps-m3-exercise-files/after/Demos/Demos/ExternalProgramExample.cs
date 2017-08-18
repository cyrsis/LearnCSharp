using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class ExternalProgramExample
    {

        [TestMethod]
        public void SimpleStartByFileExtensionExample()
        {
            //Process.Start(@"c:\temp\hello.txt");


            const string applicationName = "notepad.exe";
            const string applicationArguments = @"c:\temp\hello.data";

            Process.Start(applicationName, applicationArguments);
        }













        [TestMethod]
        public void RedirectingOutputExample()
        {
            var pi = new ProcessStartInfo
                         {
                             FileName = "cmd.exe",
                             Arguments = "/C DATE /T",
                             RedirectStandardOutput = true,
                             UseShellExecute = false // allows redirection of output
                         };

            var p = Process.Start(pi);           

            var dateFromCommandLine = p.StandardOutput.ReadToEnd();
        }




    }
}
