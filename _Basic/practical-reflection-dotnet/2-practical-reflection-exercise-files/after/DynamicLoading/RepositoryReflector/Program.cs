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

            type = typeof(CSVRepository);
            ReflectType(type);

            type = typeof(ServiceRepository);
            ReflectType(type);

            type = typeof(SQLRepository);
            ReflectType(type);

            Console.ReadLine();
        }

        private static void ReflectType(Type type)
        {
            Console.WriteLine(type.Name);
            Console.WriteLine(type.AssemblyQualifiedName);
            Console.WriteLine();
            //Console.Write("FullName=");
            //Console.WriteLine(type.FullName);
            //Console.Write("Assembly=");
            //Console.WriteLine(type.Assembly.GetName().Name);
            //Console.Write("Version=");
            //Console.WriteLine(type.Assembly.GetName().Version);
            //Console.Write("Culture=");
            //Console.WriteLine(type.Assembly.GetName().CultureName);
            //Console.Write("PublicKeyToken=");
            //Console.WriteLine(BitConverter.ToString(
            //    type.Assembly.GetName().GetPublicKeyToken()));
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
