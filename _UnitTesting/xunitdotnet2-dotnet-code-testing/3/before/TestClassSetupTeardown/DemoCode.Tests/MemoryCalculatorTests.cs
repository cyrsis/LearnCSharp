using Xunit;
using Xunit.Abstractions;

namespace DemoCode.Tests
{
    public class MemoryCalculatorTests
    {
        private readonly ITestOutputHelper _testOutput;

        public MemoryCalculatorTests(ITestOutputHelper helper)
        {
            _testOutput = helper;
        }

        [Fact]
        public void ShouldAdd()
        {
            _testOutput.WriteLine("Executing ShouldAdd");

            using (var sut = new MemoryCalculator())
            {
                sut.Add(10);
                sut.Add(5);

                Assert.Equal(15, sut.CurrentValue);
            }
        }


        [Fact]
        public void ShouldSubtract()
        {
            _testOutput.WriteLine("Executing ShouldSubtract");

            using (var sut = new MemoryCalculator())
            {
                sut.Subtract(5);

                Assert.Equal(-5, sut.CurrentValue);
            }
        }


        [Fact]
        public void ShouldDivide()
        {
            _testOutput.WriteLine("Executing ShouldDivide");

            using (var sut = new MemoryCalculator())
            {
                sut.Add(10);
                sut.Divide(2);

                Assert.Equal(5, sut.CurrentValue);
            }
        }
    }
}
