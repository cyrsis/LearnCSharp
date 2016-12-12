using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] files = new string[] {
                "report.pdf",
                "test.pdf",
                "setup.exe",
                "install.exe"
            };

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            {
                for (int i = 0; i < files.Length; i++)
                {
                    var currentFile = files[i];
                    var nextFile = i < files.Length - 1 ? files[i + 1] : "(this is the last one)";
                    Console.WriteLine("this file is {0} and the next file is {1}", currentFile, nextFile);
                }
            }

            {
                int i = 0;
                while (i < files.Length)
                {
                    Console.WriteLine("showing with while: {0}", files[i]);
                    i++;
                }
            }

            {
                int i = 0;
                do
                {
                    Console.WriteLine("showing with do/while: {0}", files[i]);
                    i++;
                } while (i < files.Length);

            }



            Console.ReadLine();
        }
    }
}
