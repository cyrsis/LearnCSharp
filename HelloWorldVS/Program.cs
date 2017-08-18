using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldVS
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];

            Int32 x = 2;

            x++;


            Int32 result = 4 / x;            
            Console.WriteLine(result);            

            Console.WriteLine(result.GetType().AssemblyQualifiedName);            
            Console.WriteLine("Hello, " + name);
            Console.ReadLine();
        }
    }
}
