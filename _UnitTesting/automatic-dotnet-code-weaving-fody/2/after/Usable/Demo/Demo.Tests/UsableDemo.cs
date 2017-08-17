using Xunit;

namespace Demo.Tests
{
    public class UsableDemo
    {
        [Fact]
        public void ManualUsing()
        {
            var o = new SomeClass();

            o.ManualUsing();
        }

        [Fact]
        public void AutoUsing()
        {
            var o = new SomeClass();

            o.AutoUsing();
        }
    }
}
