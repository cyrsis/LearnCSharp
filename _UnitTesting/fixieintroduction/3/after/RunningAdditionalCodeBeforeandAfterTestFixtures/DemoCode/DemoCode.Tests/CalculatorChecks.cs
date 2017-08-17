using System;
using System.Diagnostics;
using Should;

namespace DemoCode.Tests
{
    public class CalculatorChecks : IDisposable
    {
        public CalculatorChecks()
        {
            Debug.WriteLine("ctor CalculatorChecks");
        }

        public void ShouldAddInts()
        {
            Debug.WriteLine("               Executing ShouldAddInts");

            var sut = new DemoCode.Calculator();

            var result = sut.AddInts(1, 2);

            result.ShouldEqual(3);
        }


        public void ShouldAddDoubles()
        {
            Debug.WriteLine("               Executing ShouldAddDoubles");

            var sut = new DemoCode.Calculator();

            var result = sut.AddDoubles(1.1, 2.2);

            result.ShouldEqual(3.3, 0.0001);
        }

        public void Dispose()
        {
            Debug.WriteLine("Dispose CalculatorChecks");
        }
    }
}
