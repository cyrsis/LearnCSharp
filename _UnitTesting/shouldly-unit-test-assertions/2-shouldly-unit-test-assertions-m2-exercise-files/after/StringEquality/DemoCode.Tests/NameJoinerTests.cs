using Xunit;
using Shouldly;

namespace DemoCode.Tests
{
    public class NameJoinerTests
    {
        [Fact]
        public void ShouldJoinNames()
        {
            var nameJoiner = new NameJoiner();

            nameJoiner.Join("Sarah", "Smith").ShouldNotBe("Sarah Smith");
        }

    }
}
