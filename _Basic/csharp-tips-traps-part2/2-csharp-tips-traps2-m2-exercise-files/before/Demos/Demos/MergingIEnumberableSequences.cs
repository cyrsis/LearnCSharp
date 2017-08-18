using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class MergingIEnumberableSequences
    {
        
        [TestMethod]
        public void EqualLengthSequences()
        {
            var names = new [] {"Sarah", "Gentry", "Amrit"};

            var ages = new[] {20, 22, 36};

            var namesAndAges = names.Zip(ages, CombineNameAndAge);           
        }


        private string CombineNameAndAge(string name, int age)
        {
            return name + ": " + age;
        }









        [TestMethod]
        public void DifferentLengthSequences()
        {
            var names = new[] { "Sarah", "Gentry", "Amrit", "Mark" };

            var ages = new[] { 20, 22, 36 };

            // Using lambda
            var namesAndAges = names.Zip(ages, (name, age) => name + ": " + age);
        }








        [TestMethod]
        public void CreatingObjects()
        {
            var names = new[] { "Sarah", "Gentry", "Amrit" };

            var ages = new[] { 20, 22, 36 };

            var namesAndAges = names.Zip(ages, (name, age) => Tuple.Create(name, age));
            
            // Using method group: 
            namesAndAges = names.Zip(ages, Tuple.Create);
        }


    }   
}