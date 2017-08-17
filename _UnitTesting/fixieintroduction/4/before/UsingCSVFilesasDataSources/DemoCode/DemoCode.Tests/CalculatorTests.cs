using System;
using System.Diagnostics;
using System.Linq.Expressions;
using Should;

namespace DemoCode.Tests
{   
    public class CalculatorTests
    {
        [TestCaseData(1, 2, 3)]
        [TestCaseData(-10, -2, -12)]
        [TestCaseData(10, -2, 8)]
        public void ShouldAddInts(int firstNumber, int secondNumber, int expectedResult)
        {
            Debug.WriteLine("Executing ShouldAddInts {0} {1} {2}", firstNumber, secondNumber, expectedResult);

            var sut = new DemoCode.Calculator();

            var result = sut.AddInts(firstNumber, secondNumber);

            result.ShouldEqual(expectedResult);
        }
    }
}
