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
            Employee employee1 = new Employee()
            {
                FirstName = "Jim",
                LastName = "Smith",
                Age = 34,
                DateOfEmployment = new DateTime(2001, 01, 01),
                Department = "Sales"
            };
            Console.WriteLine(employee1.GetNameTag());

            Customer customer1 = new Customer()
            {
                FirstName = "Joe",
                LastName = "Thompson",
                Age = 31,
                DateOfAcquisition = new DateTime(2003, 11, 01),
                Department = "Marketing"
            };
            Console.WriteLine(customer1.GetNameTag());

            Customer customer2 = new Customer()
            {
                FirstName = "Hank",
                LastName = "Anders",
                Age = 31,
                DateOfAcquisition = new DateTime(2003, 3, 01),
                Department = "Research"
            };

            Project project1 = new Project()
            {
                Title = "Smith & Sons",
                Description = "Twenty real estate buildings to be analyzed and put on sale"
            };
            Project project2 = new Project()
            {
                Title = "Reboot 2010",
                Description = "Internal project which aims to increase sales by 120% in 12 months."
            };

            List<IFlashcard> flashcards = new List<IFlashcard>();
            flashcards.Add(customer1);
            flashcards.Add(customer2);
            flashcards.Add(project1);
            flashcards.Add(project2);
            foreach (var flashcard in flashcards)
            {
                Console.WriteLine();
                Console.WriteLine("QUESTION: " + flashcard.GetFlashcardQuestion());
                Console.ReadLine();
                Console.WriteLine("\t" + flashcard.GetFlashcardAnswer());
            }


            Console.ReadLine();
        }
    }

    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public abstract string GetNameTag();
    }

    public class Employee : Person
    {
        public DateTime DateOfEmployment { get; set; }

        public override string GetNameTag()
        {
            return FirstName;
        }
    }

    public class Customer : Person, IFlashcard
    {
        public DateTime DateOfAcquisition { get; set; }

        public override string GetNameTag()
        {
            return "Mr. " + LastName;
        }

        public string GetFlashcardQuestion()
        {
            return FirstName + " " + LastName;
        }

        public string GetFlashcardAnswer()
        {
            return Department;
        }
    }

    public interface IFlashcard
    {
        string GetFlashcardQuestion();
        string GetFlashcardAnswer();
    }

    public class Project : IFlashcard
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string GetFlashcardQuestion()
        {
            return Title;
        }

        public string GetFlashcardAnswer()
        {
            return Description;
        }
    }

}
