using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.InsideArraysChangePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person{Name="Bill", Age=7},
                new Person{Name="Ben", Age=8}
            };

			// this is fine. Not actually replacing elements
			foreach (Person person in people)
			{
				person.Age = 20;
			}

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, age={1}", Name, Age);
        }
    }

}
