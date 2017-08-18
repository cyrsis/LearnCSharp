using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class IntegerNumberSequenceGeneration
    {
        
        [TestMethod]
        public void EnumerableRange()
        {
            var oneToTen = Enumerable.Range(1, 10);

            int[] twentyToThirty = Enumerable.Range(20, 11).ToArray();

            List<int> oneHundredToOneThirty = Enumerable.Range(100, 31).ToList();
        }
    }   
}