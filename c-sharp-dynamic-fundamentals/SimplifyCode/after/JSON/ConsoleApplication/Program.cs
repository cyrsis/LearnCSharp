using System;
using Newtonsoft.Json;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    {
        const string CustomerJson = "{'firstName': 'Sarah','SecondName': 'Smith'}";

        static void Main(string[] args)
        {
            dynamic c = JsonConvert.DeserializeObject(CustomerJson);

            var firstName = c.firstName;
            var secondName = c.SecondName;

            WriteLine($"Customer name is: {firstName} {secondName}");


            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }  
}
