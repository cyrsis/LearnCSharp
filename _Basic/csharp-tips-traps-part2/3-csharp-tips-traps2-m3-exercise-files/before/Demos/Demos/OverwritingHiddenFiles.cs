using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class OverwritingHiddenFiles
    {
        [TestMethod]
        public void Example()
        {
            const string path = @"C:\Temp\psfiledemo\hidden.txt";

            try
            {                
                File.Create(path);

                // or:  new FileStream(path, FileMode.Create);
            }
            catch (Exception e)
            {                
            }

            // To overwrite hidden file, explicitly delete it first:
            File.Delete(path);
            File.Create(path);
        }
    }  
}