﻿using Xunit;

namespace DemoCode.Tests
{    
    public class MemoryCalculatorSubtractTests
    {        
        [Fact]
        public void ShouldSubtractPositiveNumbers()
        {
            var sut = new MemoryCalculator();

            sut.Subtract(5);

            Assert.Equal(-5, sut.CurrentValue);
        }

    }
}
