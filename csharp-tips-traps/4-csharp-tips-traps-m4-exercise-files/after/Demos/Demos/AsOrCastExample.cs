using System.Diagnostics;
using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class AsOrCastExample
    {

        [TestMethod]
        public void Cast()
        {
            object name = "Sarah";

            Person p = (Person) name;

            Debug.WriteLine(p.Name);
        }








        [TestMethod]
        public void AsBad()
        {
            object name = "Sarah";

            Person p = name as Person;

            // missing null check should go here

            Debug.WriteLine(p.Name);
        }








        [TestMethod]
        public void AsBetter()
        {
            object name = "Sarah";

            Person p = name as Person;
           
            if (p == null)
            {
                p = new Person { Name = "Default" };
            }

            Debug.WriteLine(p.Name);
        }
    }
}
