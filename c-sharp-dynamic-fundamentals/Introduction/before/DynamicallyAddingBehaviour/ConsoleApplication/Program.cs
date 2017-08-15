using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic customer = new ExpandoObject();

            customer.Print = (Action)(() =>
            {
                WriteLine("\nCUSTOMER PROPERTIES");

                foreach (var item in customer)
                {
                    WriteLine($"{item.Key} : {item.Value}");
                }
            });

            customer.Count = (Func<int>)(() =>
            {
                var c = (IDictionary<string, object>)customer;
                return c.Count;
            });

            customer.ID = "42";
            WriteLine(customer.ID);

            customer.sb = new StringBuilder("a string builder");


            WriteLine("(enter 'done' to complete adding properties)");

            string propertyName = GetPropertyName();

            while (propertyName != "done")
            {
                string propertyValue = GetPropertyValue();

                var c = (IDictionary<string, object>) customer;

                c.Add(propertyName, propertyValue);

                propertyName = GetPropertyName();
            }


            customer.Print();
            WriteLine($"Total property count: {customer.Count()}");


            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }


        private static string GetPropertyName()
        {
            Write("Please enter attribute Name: ");
            return ReadLine();
        }

        private static string GetPropertyValue()
        {
            Write("Please enter attribute value: ");
            return ReadLine();
        }
    }
  
}
