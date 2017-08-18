using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PoorMansContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();

            container.ConstructorResolver = new AttributeBasedConstructorResolver();
            
            // registrations here

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }

    public class AttributeBasedConstructorResolver : ConstructorResolver
    {
        public override ConstructorInfo GetConstructor(ConstructorInfo[] constructors)
        {
            ConstructorInfo constructorToResolve = null;

            foreach (ConstructorInfo constructor in constructors)
            {
                object[] attributes = constructor.GetCustomAttributes(typeof(InjectionConstructorAttribute), false);
                if (attributes != null && attributes.Count() > 0)
                {
                    constructorToResolve = constructor;
                    break;
                }
            }

            return constructorToResolve;
        }
    }
}
