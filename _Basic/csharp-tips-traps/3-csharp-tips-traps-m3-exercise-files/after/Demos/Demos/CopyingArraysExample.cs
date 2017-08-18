using System;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class CopyingArraysExample
    {

        [TestMethod]
        public void CloneWithReferenceTypes()
        {
            var names = new[] { "Sarah", "Gentry", "Amrit", "Amrit2" };

            string[] shallowCopy = (string[]) names.Clone();

            var originalElementZero = names[0];

            var copyElementZero = shallowCopy[0];

            var isSameReference =
                object.ReferenceEquals(originalElementZero, copyElementZero);
        }








        [TestMethod]
        public void CloneWithValueTypes()
        {
            var ints = new[] { 1, 2, 3 };

            int[] shallowCopy = (int[])ints.Clone();

            var originalElementZero = ints[0];

            var copyElementZero = shallowCopy[0];

            var isSameReference =
                object.ReferenceEquals(originalElementZero, copyElementZero);
        }








        [TestMethod]
        public void CopyTo()
        {
            var names = new string[6];
            names[0] = "Sarah";
            names[1] = "Gentry";
            names[2] = "Amrit";
            names[3] = "Amrit2";

            var moreNames = new[] { "Sally", "Peter", "Fred" };

            moreNames.CopyTo(names, 3);

            var originalSally = moreNames[0];
            var copiedSally = names[3];

            var isSameReference =
                object.ReferenceEquals(originalSally, copiedSally);
        }









        [TestMethod]
        public void ConvertAll()
        {
            var ints = new[] {1, 2, 3 };

            BigInteger[] bigInts = Array.ConvertAll(ints, x => new BigInteger(x));
        }














        [TestMethod]
        public void ConstrainedCopy()
        {
            var things = new object[] { "Sarah", 1};

            var thingsCopy = new object[2];            

            Array.ConstrainedCopy(things, 0, thingsCopy, 0, 2);

            var strings = new string[2];

            //things.CopyTo(strings, 0);

            Array.ConstrainedCopy(things, 0, strings, 0, 2);
        }












        [TestMethod]
        public void Resize()
        {
            var names = new[] { "Sarah", "Gentry", "Amrit", "Amrit2" };

            Array.Resize(ref names, 2);

            Array.Resize(ref names, 4);
        }
    }
}
