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
            Customer customer = new Customer("Jim", "Smith");
            Console.WriteLine(customer.Display());
            Console.ReadLine();
        }
    }

    public class Customer
    {
        private string _firstName;
        private string _lastName;

        public Customer(string firstName, string lastName) : this(lastName)
        {
            _firstName = firstName;
        }

        public Customer(string lastName)
        {
            _lastName = lastName;
        }

        public string Display()
        {
            return String.Format("{0}, {1}", _lastName, _firstName);
        }

    }

    //public class Person
    //{
    //    public Person()
    //    {
    //        Console.WriteLine("this will always be called unless some other constructor in the base class is explicitly called");
    //    }

    //    public Person(string firstName, string lastName)
    //    {
    //        Console.WriteLine("in first/last name person constructor");
    //    }

    //    protected void Initialize()
    //    {
    //        Console.WriteLine("this initializes variables which only SOME derived classes need");
    //    }
    //}


}
