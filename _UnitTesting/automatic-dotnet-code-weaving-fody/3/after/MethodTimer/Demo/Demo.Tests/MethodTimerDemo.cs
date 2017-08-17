using Xunit;

namespace Demo.Tests
{
    public class MethodTimerDemo
    {
        [Fact]
        public void Example()
        {
            var sut = new SomeClass();

            sut.DoWork();
        }
    }
}
