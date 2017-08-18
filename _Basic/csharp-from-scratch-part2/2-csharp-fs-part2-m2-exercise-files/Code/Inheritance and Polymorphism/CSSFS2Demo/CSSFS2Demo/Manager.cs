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
            base(name, street, city, state, postalCode)
        {
        }

        public override string DoWork()
        {
            return "Manager doing work";
        }

        public string GivePraise()
        {
            return "Manager giving praise.";
        }
    }
}
