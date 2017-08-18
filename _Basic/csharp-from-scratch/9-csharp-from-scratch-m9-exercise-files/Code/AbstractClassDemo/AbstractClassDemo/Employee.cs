using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        private DateTime HireDate;

        public virtual void Hire()
        {
            HireDate = DateTime.Now;
        }

        public abstract void GiveRaise();
    }
}
