using Shouldly;

namespace DemoCode.Tests
{
    class MemoryCalculatorTests
    {
        public void ShouldAdd()
        {
            var calculator = new MemoryCalculator();

            calculator.Add(1);
            calculator.Add(2);

            calculator.CurrentValue.ShouldBe(3);
        }
    }
}
