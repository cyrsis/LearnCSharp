using System.Reflection;
using static System.Console;

namespace ConsoleApplication
{
    class Customer
    {
        public object FirstName { get; set; }
        public dynamic SecondName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {         
            Customer c = new Customer();

            //c.FirstName.SomeDynamicMethod();
            //c.SecondName.SomeDynamicMethod();


            PropertyInfo firstNameProperty = typeof(Customer).GetProperty("FirstName");                        
            foreach (var attribute in firstNameProperty.CustomAttributes)
            {
                WriteLine(attribute);
            }
            WriteLine($"{firstNameProperty.PropertyType} FirstName");

            WriteLine();

            PropertyInfo secondNameProperty = typeof(Customer).GetProperty("SecondName");
            foreach (var attribute in secondNameProperty.CustomAttributes)
            {
                WriteLine(attribute);
            }
            WriteLine($"{secondNameProperty.PropertyType} SecondName");


            
            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }
}
