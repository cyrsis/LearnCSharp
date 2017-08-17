using System;
using Xunit;
using Shouldly;

namespace DemoCode.Tests
{   
    public class CalculatorTests
    {
        [Fact]
        public void ShouldThrowExceptionWhenDivideByZero()
        {
            var calculator = new Calculator();

            Should.Throw<DivideByZeroException>(() => calculator.Divide(100, 1));
        }

        [Fact]
        public void ShouldThrowExceptionWhenNumberTooBig()
        {
            var calculator = new Calculator();

            ArgumentOutOfRangeException ex = Should.Throw<ArgumentOutOfRangeException>(() => calculator.Divide(101, 0));

            ex.ParamName.ShouldBe("number");
        }
    }
}
