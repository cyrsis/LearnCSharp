using System.Collections.Generic;
using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class SortedCollections
    {

        [TestMethod]
        public void SimpleSortedSet()
        {
            var s = new SortedSet<int>();

            s.Add(5);
            s.Add(7);
            s.Add(2);

            // No duplicates - no exception
            s.Add(2);
        }








        [TestMethod]
        public void SortedSetWithCustomIComparer()
        {
            var s = new SortedSet<string>(new ByStringLengthComparer());

            s.Add("Sarah");
            s.Add("Gentry");
            s.Add("Amrit");
        }









        [TestMethod]
        public void SortedDictionary()
        {
            var s = new SortedDictionary<string, int>();

            s.Add("Sarah", 34);
            s.Add("Gentry", 22);
            s.Add("Amrit", 37);

            // No duplicates - exception
            s.Add("Amrit", 37);
        }






        [TestMethod]
        public void SortedList()
        {
            var s = new SortedList<string, int>();

            s.Add("Sarah", 34);
            s.Add("Gentry", 22);
            s.Add("Amrit", 37);

            // No duplicates - exception
            s.Add("Amrit", 37);
        }


        // SortedList v SortedDictionary

        // MSDN: http://bit.ly/pscssorted (see remarks section)

        // SortedList 
        //    - uses less memory than SortedDictionary
        //    - efficient indexed retrieval of keys and values via Keys and Values properties

        // SortedDictionary 
        //    - faster insert and remove for unsorted data
    }
}