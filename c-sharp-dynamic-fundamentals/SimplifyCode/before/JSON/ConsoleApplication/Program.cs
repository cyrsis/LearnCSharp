using System;
using Newtonsoft.Json;
using static System.Console;

namespace ConsoleApplication
{
    class Customer
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }        
    }

    class Program
    {
        const string CustomerJson = "{'FirstName': 'Sarah','SecondName': 'Smith'}";

        static void Main(string[] args)
        {
            Customer c = JsonConvert.DeserializeObject<Customer>(CustomerJson);

            var firstName = c.FirstName;
            var secondName = c.SecondName;

            WriteLine($"Customer name is: {firstName} {secondName}");


            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }  
}
