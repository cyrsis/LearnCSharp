using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFS2Demo
{
    public class Employee
    {
        public string Name { get; set; }
        public AddressInfo Address { get; set; }
        public InsuranceInfo Insurance { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string street, string city, string state, string postalCode) :
            this(name, street, city, state, postalCode, 50000)
        {
        }

        public Employee(string name, string street, string city, string state, string postalCode, double salary)
        {
            Name = name;
            Salary = salary;
            Address = new AddressInfo()
            {
                Street = street,
                City = city,
                State = state,
                PostalCode = postalCode
            };
        }

        public virtual string DoWork()
        {
            return "Employee doing work!";
        }

        public virtual string DoWork(string workType)
        {
            return "Doing " + workType;
        }

        public override string ToString()
        {
            string retVal = Name + " " +
                Address.Street + " " +
                Address.City + " " +
                Address.State + " " +
                Address.PostalCode + " " +
                "\tSalary: " + Salary + "\t";

            if (Insurance != null)
            {
                retVal += " " +
                    Insurance.PolicyName + " " +
                    Insurance.PolicyId;
            }
            return retVal;            
        }

    }
}
