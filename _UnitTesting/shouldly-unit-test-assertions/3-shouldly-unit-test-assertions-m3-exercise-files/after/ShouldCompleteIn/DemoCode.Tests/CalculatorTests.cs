using System;
using Xunit;
using Shouldly;

namespace DemoCode.Tests
{   
    public class CalculatorTests
    {
        [Fact] 
        public void ShouldAddNumbers()
        {
            var calculator = new Calculator();

            Should.CompleteIn(() => calculator.AddInts(1, 2), TimeSpan.FromMilliseconds(100));
        }

    }
}
