using Xunit;
using Shouldly;

namespace DemoCode.Tests
{   
    public class CalculatorTests
    {
        public CalculatorTests()
        {
            ShouldlyConfiguration.DefaultFloatingPointTolerance = 0.001;
        }

        [Fact]
        public void ShouldAddInts()
        {
            var calculator = new Calculator();

            calculator.AddInts(1, 2).ShouldBe(3);
        }

        [Fact]
        public void ShouldAddDoubles()
        {
            var calculator = new Calculator();

            calculator.AddDoubles(1.1, 2.2).ShouldBe(3.3);
        }

        [Fact]
        public void ShouldNotBeZero()
        {
            var calculator = new Calculator();

            calculator.AddInts(0, 0).ShouldNotBe(0);
        }
    }
}
