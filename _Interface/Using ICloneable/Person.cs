using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_ICloneable
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address MailingAddress { get; set; }
        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            MailingAddress = address;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + ", " +
                MailingAddress.ToString();
        }

        public Person Clone(bool deep)
        {
            Person result = (Person)this.MemberwiseClone();
            if (deep) result.MailingAddress = MailingAddress.Clone();
            return result;
        }
    }
}
