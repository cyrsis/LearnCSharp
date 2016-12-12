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
            Employee employee = Person.Create("employee", "Jim", "Smith") as Employee;
            Console.WriteLine(employee.GetNameTag());

            Customer customer = new Customer();
            customer.FirstName = "Joe";
            customer.LastName = "Thompson";
            Console.WriteLine(customer.GetNameTag());

            //Person person = new Person();
            //person.FirstName = "Jack";
            //person.LastName = "Reynolds";
            //Console.WriteLine(person.GetNameTag());

            Console.ReadLine();
        }
    }

    //virtual / override
    //abstract
    //static

    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract string GetNameTag();

        public static Person Create(string kind, string firstName, string lastName)
        {
            switch (kind)
            {
                case "employee":
                    Employee employee = new Employee();
                    employee.FirstName = firstName;
                    employee.LastName = lastName;
                    return employee;
                case "customer":
                    Customer customer = new Customer();
                    customer.FirstName = firstName;
                    customer.LastName = lastName;
                    return customer;
                default:
                    return null;
            }
        }

    }

    public class Employee : Person
    {
        public override string GetNameTag()
        {
            return FirstName;
        }
    }

    public class Customer : Person
    {
        public override string GetNameTag()
        {
            return "Mr. " + LastName;
        }
    }



}
