using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace csharp_clr
{
    public class Animal
    {
        [Required]
        public string Name { get; set; }
    }

    public class CustomAttributes
    {
        static void FindCustomAttributes(string[] args)
        {
            Type type = typeof(Animal);
            PropertyInfo propertyInfo = type.GetProperty("Name");
            object[] attributes = propertyInfo.GetCustomAttributes(false);
            foreach (Attribute attribute in attributes)
            {
                Console.WriteLine(attribute.GetType().Name);
            }
        }
    }
}