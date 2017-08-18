using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class SetOperations
    {
        
        [TestMethod]
        public void Concat()
        {
            var oneToFive = Enumerable.Range(1, 5);
            var fiveToTen = Enumerable.Range(5, 6);

            var result = oneToFive.Concat(fiveToTen);
        }










        [TestMethod]
        public void Union()
        {
            var oneToFive = Enumerable.Range(1, 5);
            var fiveToTen = Enumerable.Range(5, 6);

            var result = oneToFive.Union(fiveToTen);
        }









        [TestMethod]
        public void Intersect()
        {
            var oneToFive = Enumerable.Range(1, 5);
            var fiveToTen = Enumerable.Range(5, 6);

            var result = oneToFive.Intersect(fiveToTen);
        }










        [TestMethod]
        public void Except()
        {
            var oneToFive = Enumerable.Range(1, 5);
            var fiveToTen = Enumerable.Range(5, 6);

            var result = oneToFive.Except(fiveToTen);



            var names = new[] {"Sarah", "Gentry", "Amrit"};
            
            var namesResult = names.Except(new[] {"Sarah", "Amrit", "Mark"});
        }
    }   
}