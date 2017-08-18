using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFS2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe Smith", "100 Main Street", "Boston", "MA", "01010");
            Console.WriteLine(joe.ToString());
            joe.Insurance = new InsuranceInfo() { PolicyName = "Life", PolicyId = "123" };
            Console.WriteLine(joe.ToString());

            Manager dave = new Manager("Dave Jones", "200 Center Street", "Boston", "MA", "01010");
            Console.WriteLine(dave);

            Console.WriteLine(joe.DoWork());
            Console.WriteLine(dave.DoWork());

            Employee steve = new Manager("Steve Levine", "300 Market Street", "Boston", "MA", "01010");
            Console.WriteLine("Steve do work: " + steve.DoWork());

            Console.WriteLine("================");

            List<Employee> employees = new List<Employee>();
            employees.Add(joe);
            employees.Add(dave);
            employees.Add(steve);

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.DoWork());
            }

        }
    }
}
