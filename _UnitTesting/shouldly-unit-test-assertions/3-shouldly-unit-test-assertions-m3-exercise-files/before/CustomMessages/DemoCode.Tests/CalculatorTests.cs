using Xunit;
using Shouldly;

namespace DemoCode.Tests
{   
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAddInts()
        {
            var calculator = new Calculator();

            calculator.AddInts(1, 2).ShouldBe(3);
        }
 
    }
}
