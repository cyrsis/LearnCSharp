using Xunit;

namespace DemoCode.Tests
{   
    public class MemoryCalculatorTests
    {
        [Fact]
        public void ShouldDividePositiveNumbers()
        {
            var calculator = new MemoryCalculator();

            calculator.Add(10);
            calculator.Divide(2);

            Assert.Equal(5, calculator.CurrentValue);
        }

        [Fact]
        public void ShouldSubtractPositiveNumbers()
        {
            var calculator = new MemoryCalculator();

            calculator.Subtract(5);

            Assert.Equal(-5, calculator.CurrentValue);
        }

        [Fact]
        public void ShouldAddPositiveNumbers()
        {
            var calculator = new MemoryCalculator();

            calculator.Add(10);
            calculator.Add(5);

            Assert.Equal(15, calculator.CurrentValue);
        }
    }
}
