using System;
using System.Security;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var meeting = new Tuple<Customer, Employee, MeetingRoom, List<string>>(
                new Customer(2343),
                new Employee(23),
                new MeetingRoom(23),
                new List<string>()
                {
                    "Next month's budget",
                    "Possible Merger",
                    "New Employees"
                });

            meeting.Item4.ForEach(c => Console.WriteLine(c));


            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(int id)
        {
            //...
        }

    }

    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int id)
        {
            //...
        }
    }

    class MeetingRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomNumber { get; set; }
        public float SquareFeet { get; set; }

        public MeetingRoom(int id)
        {
            //...
        }
    }





}
