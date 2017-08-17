using NUnit.Framework;
using Shouldly;

namespace DemoCode.Tests
{
    [TestFixture]
    public class MemoryCalculatorTests
    {
        [Test]
        public void ShouldAddNumbers()
        {
            var calculator = new MemoryCalculator();

            calculator.Add(1);
            calculator.Add(2);

            // Assert.That(calculator.CurrentValue, Is.EqualTo(3));
            calculator.CurrentValue.ShouldBe(3);
        }
    }
}
