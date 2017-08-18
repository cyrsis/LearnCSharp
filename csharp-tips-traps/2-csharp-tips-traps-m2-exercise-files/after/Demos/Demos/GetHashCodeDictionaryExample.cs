using System;
using System.Collections.Generic;
using System.Diagnostics;
using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class GetHashCodeDictionaryExample
    {
        [TestMethod]
        public void BadGetHashCodeExample()
        {
            var p1 = new PersonIdBadHash {Id = 1};
            var p2 = new PersonIdBadHash {Id = 2};

            var d = new Dictionary<PersonIdBadHash, string>();

            d.Add(p1, "Sarah");
            d.Add(p2, "John");

            var john = d[p2];

            p2.Id = 99;

            john = d[p2];
        }





        [TestMethod]
        public void BetterGetHashCodeExample()
        {
            var p1 = new PersonIdBetterHash(1);
            var p2 = new PersonIdBetterHash(2);

            var d = new Dictionary<PersonIdBetterHash, string>();

            d.Add(p1, "Sarah");
            d.Add(p2, "John");

            var john = d[p2];

            // p2.Id = 99; Id is now immutable, so our hashcode cannot change now
        }
    }
}
