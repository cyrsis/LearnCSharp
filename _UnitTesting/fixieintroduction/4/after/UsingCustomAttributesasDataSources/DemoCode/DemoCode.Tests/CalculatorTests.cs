using System.Diagnostics;
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

        [TestCaseData(1.1, 2.2, 3.3)]
        [TestCaseData(2.2, 2.2, 4.4)]
        public void ShouldAddDoubles(double firstNumber, double secondNumber, double expectedResult)
        {
            var sut = new DemoCode.Calculator();

            var result = sut.AddDoubles(firstNumber, secondNumber);

            result.ShouldEqual(expectedResult, 0.0001);
        }

    }
}
