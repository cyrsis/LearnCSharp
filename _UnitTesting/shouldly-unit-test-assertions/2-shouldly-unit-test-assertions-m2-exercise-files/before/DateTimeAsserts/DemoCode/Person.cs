using System;

namespace DemoCode
{
    public class Person
    {
        public DateTime DateOfBirth { get; private set; }

        public Person(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }
    }
}
