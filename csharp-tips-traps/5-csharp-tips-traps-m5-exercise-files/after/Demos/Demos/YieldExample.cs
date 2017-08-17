using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class YieldExample
    {

        [TestMethod]
        public void WithoutYield()
        {
            var someNumbers = Enumerable.Range(1, 10);

            var evens = GetEvenNumbers(someNumbers);

            foreach (var even in evens)
            {
                Debug.WriteLine("Output: " + even);

                if (even == 6)
                {
                    break;
                }
            }
        }






        [TestMethod]
        public void WithYield()
        {
            var someNumbers = Enumerable.Range(1, 10);

            var evens = GetEvenNumbersUsingYield(someNumbers);

            foreach (var even in evens)
            {
                Debug.WriteLine("Output: " + even);

                if (even == 6)
                {
                    break;
                }
            }
        }






        [TestMethod]
        public void ComposingWithYield()
        {
            var someNumbers = Enumerable.Range(1, 10);

            var twoAndSix = GetTwoAnd6(GetEvenNumbersUsingYield(someNumbers));
            
            foreach (var number in twoAndSix)
            {
                Debug.WriteLine("Output: " + number);
            }

            // http://bit.ly/pscsyield
        }









        IList<int> GetEvenNumbers(IEnumerable<int> numbers)
        {
            List<int> evens = new List<int>();

            foreach (var number in numbers)
            {
                Debug.WriteLine("GetEvenNumbers: Processing input number: " + number);

                    if (number%2 == 0)
                    {
                        evens.Add(number);
                    }
            }

            return evens;
        }







        IEnumerable<int> GetEvenNumbersUsingYield(IEnumerable<int> numbers)
        {           
            foreach (var number in numbers)
            {
                Debug.WriteLine("GetEvenNumbersUsingYield: Processing input number: " + number);

                if (number % 2 == 0)
                {
                    Debug.WriteLine("GetEvenNumbersUsingYield: yielding: " + number);
                    yield return number;
                }
            }
        }







        IEnumerable<int> GetTwoAnd6(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                Debug.WriteLine("GetTwoAnd6: Processing input number: " + number);

                if (number  == 2 || number == 6)
                {
                    Debug.WriteLine("GetTwoAnd6: yielding: " + number);

                    yield return number;                    
                }
            }
        }
    }
}
