using System;

namespace LanguageBinders
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }

        static void Print(dynamic s)
        {
            Console.WriteLine(s.ToUpper());
        }
    }
}
