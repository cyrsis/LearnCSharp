using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class StaticArrayMethodsExample
    {      

        [TestMethod]
        public void ReadonlyCollection()
        {
            var names = new[] { "Sarah", "Gentry", "Amrit", "Amrit2" };

            ReadOnlyCollection<string> ro = Array.AsReadOnly(names);

            // ro.Add("x"); // no add method on ReadOnlyCollection
        }










        [TestMethod]
        public void FindingItems()
        {
            var names = new[] { "Sarah", "Gentry", "Amrit1", "Amrit2" };

            int gentryIndex = Array.BinarySearch(names, "Gentry");

            int amrit1Index = Array.FindIndex(names, x => x.StartsWith("Amrit"));

            bool isGentryThere = Array.Exists(names, x => x == "Gentry");

            string lastAmrit = Array.FindLast(names, x => x.StartsWith("Amrit"));
        }









        [TestMethod]
        public void ForEach()
        {
            var names = new[] { "Sarah", "Gentry", "Amrit1", "Amrit2" };

            Array.ForEach(names, x =>
                                     {
                                         Debug.WriteLine(x);
                                         Debug.WriteLine(x.Length);                                         
                                     });
        }









        [TestMethod]
        public void Sorting()
        {
            var names = new[] { "Sarah", "Gentry", "Amrit1", "Amrit2" };

            Array.Sort(names);
        }











        [TestMethod]
        public void Truth()
        {
            var names = new[] { "Sarah", "Gentry", "Amrit1", "Amrit2" };

            bool allNamesStartWithA = Array.TrueForAll(names, x => x.StartsWith("A"));
        }











        [TestMethod]
        public void Reverse()
        {
            var ints = new[] {1,2,3};

            Array.Reverse(ints);
        }
    }
}
