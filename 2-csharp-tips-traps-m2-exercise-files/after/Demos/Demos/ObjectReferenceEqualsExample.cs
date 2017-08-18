using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class ObjectReferenceEqualsExample
    {
        [TestMethod]
        public void ExampleWhereTypeUsesValueEqualitySematics()
        {
            var a = new Uri("http://pluralsight.com");
            var b = new Uri("http://pluralsight.com");            
            
            var isEqual = a == b;

            var isSameReference = object.ReferenceEquals(a, b);

            b = a;

            isSameReference = object.ReferenceEquals(a, b);
        }






        [TestMethod]
        public void ExampleWithStringLiterals()
        {
            var s1 = "Hello";
            var s2 = "Hello";

            var isSameReference = object.ReferenceEquals(s1, s2);
        }
    }
}
