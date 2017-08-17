using System;
using System.Threading;
using Xunit;

namespace DemoCode.Tests
{    
    public class CalculatorTests
    {
        [Fact]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();

            Assert.Throws<DivideByZeroException>(() => sut.Divide(10, 0));
        }


        [Fact] 
        public void ShouldErrorWhenNumberTooBig_SLOW()
        {
            var sut = new Calculator();

            // Simulate long running test
            Thread.Sleep(TimeSpan.FromSeconds(2));

            ArgumentOutOfRangeException thrownException =
                Assert.Throws<ArgumentOutOfRangeException>(() => sut.Divide(201, 1));

            Assert.Equal("value", thrownException.ParamName);
        }


    }
}
