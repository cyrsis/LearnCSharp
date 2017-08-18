using System;
using System.IO;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook("Scott's Book");
                        
            try
            {
                using (FileStream stream = File.Open("grades.txt", FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {                    
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        float grade = float.Parse(line);
                        book.AddGrade(grade);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not locate the file grades.txt");
                return;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("No access");
                return;
            }
           

            book.WriteGrades(Console.Out);

            try
            {
                //Console.WriteLine("Please enter a name for the book");
                //book.Name = Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid name");
            }

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine("{0} {1}", stats.LetterGrade, stats.Description);
        }       
    }
}
