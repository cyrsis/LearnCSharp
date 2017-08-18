using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_craft
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            var tester = new PalindromeTester();
            var planindrome = tester.IsPalindrome("too bad i hid a boot");
            Console.WriteLine(planindrome);
        }
    }
}
