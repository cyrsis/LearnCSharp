using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook("Scott's Book");
            book.AddGrade(91f);
            book.AddGrade(89.1f);
            book.AddGrade(75f);

            GradeStatistics stats = book.ComputeStatistics();

            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;
            book.NameChanged -= OnNameChanged;            

            book.Name = "Allen's Book";
            WriteNames(book.Name);

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***");
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name changed from {0} to {1}", 
                args.OldValue, args.NewValue);
        }


        private static void WriteBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }
       

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteByteArray(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.Write("0x{0:X} ", b);
            }
            Console.WriteLine();
        }

        private static void WriteNames(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
