using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class Manager : Employee
    {
        public override void GiveRaise()
        {
            Salary += Salary * 0.05;
        }
    }
}
