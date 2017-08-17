using System;
using Should;

namespace DemoCode.Tests
{   
    public class CalculatorChecks : IDisposable
    {
        public CalculatorChecks()
        {
            
        }

        public void ShouldAddInts()
        {        
            var sut = new Calculator();

            var result = sut.AddInts(1, 2);

            result.ShouldEqual(3);
        }


        public void ShouldAddDoubles()
        {           
            var sut = new Calculator();

            var result = sut.AddDoubles(1.1, 2.2);

            result.ShouldEqual(3.3, 0.0001);
        }

        public void Dispose()
        {
            
        }
    }
}
