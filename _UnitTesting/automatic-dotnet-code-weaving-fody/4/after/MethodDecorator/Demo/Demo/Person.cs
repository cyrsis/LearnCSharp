using System;

namespace Demo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [MethodDecorator]
        public string CalculateFullName()
        {
            if (FirstName == null)
            {
                throw new ArgumentNullException();
            }

            return FirstName + " " + LastName;
        }
    }
}