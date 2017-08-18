using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFS2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe Smith", "100 Main Street", "Boston", "MA", "01010");
            Console.WriteLine(joe.ToString());
            joe.Insurance = new InsuranceInfo() { PolicyName = "Life", PolicyId = "123" };
            Console.WriteLine(joe.ToString());

        }
    }
}
