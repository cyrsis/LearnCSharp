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
            //List<string> files = new List<string>()
            //{
            //    "report1.pdf",
            //    "report2.pdf",
            //    "order.doc",
            //    "data.txt",
            //    "letter.doc",
            //    "aftereffects.doc",
            //    "letter2.doc"
            //};

            ////List<string> docFiles = new List<string>();
            ////foreach (var file in files)
            ////{
            ////    if (file.EndsWith(".doc"))
            ////        docFiles.Add(file);
            ////}

            //var docFiles = from f in files
            //               where f.EndsWith(".doc")
            //               orderby f
            //               select f;


            //foreach (var docFile in docFiles)
            //{
            //    Console.WriteLine(docFile);
            //}

            List<Customer> customers = new List<Customer> {
                new Customer {FirstName="Jim", LastName="Smith", Age=27},
                new Customer {FirstName="Hank", LastName="Moore", Age=28},
                new Customer {FirstName="Jay", LastName="Smythe", Age=44},
                new Customer {FirstName="Angie", LastName="Thompson", Age=25},
                new Customer {FirstName="Sarah", LastName="Conners", Age=66}
            };


            var youngCustomers = from c in customers
                                 where c.Age < 30
                                 select c;

            //foreach (var youngCustomer in youngCustomers)
            //{
            //    Console.WriteLine(youngCustomer.Display());
            //}

            youngCustomers.ToList().ForEach(c => Console.WriteLine(c.Display()));


            Console.ReadLine();

        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string Display()
        {
            return String.Format("{0}, {1} ({2})", LastName, FirstName, Age);
        }

    }


}
