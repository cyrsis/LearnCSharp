using System.Diagnostics;
using Should;

namespace DemoCode.Tests
{   
    public class CalculatorTests
    {
        public void ShouldAddPositiveInts()
        {
            var sut = new DemoCode.Calculator();

            var result = sut.AddInts(1, 2);

            result.ShouldEqual(3);
        }


        public void ShouldAddNegativeInts()
        {
            var sut = new DemoCode.Calculator();

            var result = sut.AddInts(-10, -2);

            result.ShouldEqual(-12);
        }


        public void ShouldAddMixedInts()
        {
            var sut = new DemoCode.Calculator();

            var result = sut.AddInts(10, -2);

            result.ShouldEqual(8);
        }


    }
}
