using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class TuplesExample
    {
        [TestMethod]
        public void CreatingTuples()
        {
            // Constructor creation

            var tupleOneElement = new Tuple<int>(1);

            var tupleTwoElement = new Tuple<int, string>(1, "hello");

            var tupleSevenElement = 
                new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
            
            var tupleEightElement = 
                new Tuple<int, int, int, int, int, int, int, Tuple<string>>(1, 2, 3, 4, 5, 6, 7, 
                                                                                                new Tuple<string>("hello"));


            // Static Create method

            var tupleThreeElement = Tuple.Create(42, "hello", DateTime.Now);
        }
        





        [TestMethod]
        public void AccessingTupleProperties()
        {
            var t = Tuple.Create(42, "hello");

            int age = t.Item1;
            string greeting = t.Item2;


            // t.Item1 = 99;    compiler error, Tuples are immutable
        }
        












        [TestMethod]
        public void ComparingTuples()
        {            
            var t1 = Tuple.Create(42, "hello");
            var t2 = Tuple.Create(42, "hello");

            // Reference equality
            var isEqualTuples = t1 == t2;

            // "value" comparison
            isEqualTuples = t1.Equals(t2);
        }










        [TestMethod]
        public void UsingTuplesToReturnMultipleValues()
        {
            var boxingOpponents = GetOpponentNames();
            
            var opponent1 = boxingOpponents.Item1;
            var opponent2 = boxingOpponents.Item2;
        }

        private Tuple<string, string> GetOpponentNames()
        {
            return new Tuple<string, string>("Fred", "Bob");
        }










        [TestMethod]
        public void UsingTuplesAsCompoundDictionaryKeys()
        {
            var t1 = Tuple.Create(1, "z");
            var t2 = Tuple.Create(2, "a");
            var t3 = Tuple.Create(1, "a");

            var d = new SortedDictionary<Tuple<int, string>, string>();

            d.Add(t1, "this is Tuple t1");
            d.Add(t2, "this is Tuple t2");
            d.Add(t3, "this is Tuple t3");

            foreach (var item in d)
            {
                Debug.WriteLine(item);
            }
        }
    }
}
