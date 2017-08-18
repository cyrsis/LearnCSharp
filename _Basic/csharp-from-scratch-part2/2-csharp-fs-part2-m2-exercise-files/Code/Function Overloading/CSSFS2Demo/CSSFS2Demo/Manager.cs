using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFS2Demo
{
    public class Manager : Employee
    {
        public Manager(string name, string street, string city, string state, string postalCode) :
            this(name, street, city, state, postalCode, 60000)
        { }


        public Manager(string name, string street, string city, string state, string postalCode, double salary) :
            base(name, street, city, state, postalCode, salary)
        {
        }

        public override string DoWork()
        {
            return "Manager doing work";
        }

        public override string DoWork(string workType)
        {
            return "supervising " + workType;
        }


        public string GivePraise()
        {
            return "Manager giving praise.";
        }
    }
}
