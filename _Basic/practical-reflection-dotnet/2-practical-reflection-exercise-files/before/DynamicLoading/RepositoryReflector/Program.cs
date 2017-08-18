using PersonRepository.CSV;
using PersonRepository.Service;
using PersonRepository.SQL;
using System;

namespace RepositoryReflector
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type;

            Console.ReadLine();
        }

        private static void ReflectType(Type type)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("FullName=");
            Console.WriteLine();
            Console.Write("Assembly=");
            Console.WriteLine();
            Console.Write("Version=");
            Console.WriteLine();
            Console.Write("Culture=");
            Console.WriteLine();
            Console.Write("PublicKeyToken=");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
