using Should;

namespace DemoCode.Tests
{
    class CalculatorTests
    {
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

            result.ShouldEqual(3.3, 0.1);
        }

        public void NumericInequality()
        {
            var sut = new Calculator();

            var result = sut.AddInts(5, 6);

            result.ShouldNotEqual(42);
        }
    }
}
