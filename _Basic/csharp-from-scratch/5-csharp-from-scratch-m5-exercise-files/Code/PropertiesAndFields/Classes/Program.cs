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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Dave = new Employee();
            Dave.Age = 35;
            Console.WriteLine("Dave's age is {0}", Dave.Age);
        }
    }
}
