using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy(@"c:\test\test.txt", @"c:\test\test.bak.txt", overwrite: true);

            LogFile("test.txt");

        }

        private static void LogFile(string fileName, bool overwrite = false, bool informAdministrator = true, bool informUser = true)
        {

        }


    }
}
