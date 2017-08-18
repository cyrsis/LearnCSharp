using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        public void Bonus(double bonusPercent)
        {
            Salary += Salary * bonusPercent;
        }

        public Employee(int age, string name, double salary, DateTime startingDate, string phoneNumber)
        {
            Age = age;
            Name = name;
            Salary = salary;
            StartingDate = startingDate;
            PhoneNumber = phoneNumber;
        }

        public Employee()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Dave = new Employee()
            {
                Age = 35,
                Name = "David Smith",
                Salary = 50000.00,
                StartingDate = new DateTime(2012, 7, 10),
                PhoneNumber = "617-555-1212"
            };
            Console.WriteLine("Dave's age is {0} he started on {1} and makes {2}", 
                Dave.Age, Dave.StartingDate, Dave.Salary);
            Dave.Bonus(0.05);
            Console.WriteLine("Dave's age is {0} he started on {1} and makes {2}",
                Dave.Age, Dave.StartingDate, Dave.Salary);

            Employee Mary = new Employee(25, "Mary Jones", 60000, new DateTime(2010, 2, 28), "212-555-1212");
            Console.WriteLine("\n\nMary's age is {0} she started on {1} and makes {2}",
                Mary.Age, Mary.StartingDate, Mary.Salary);



        }
    }
}
