using Xunit;
using Shouldly;

namespace DemoCode.Tests
{
    public class NameJoinerTests
    {
        [Fact]
        public void ShouldContainFirstName()
        {
            var nameJoiner = new NameJoiner();

            nameJoiner.Join("Sarah", "Smith").ShouldContain("Sarah");
        }

        [Fact]
        public void ShouldNotContain()
        {
            var nameJoiner = new NameJoiner();

            nameJoiner.Join("Sarah", "Smith").ShouldNotContain("Amrit");
        }

        [Fact]
        public void ShouldStartWithFirstName()
        {
            var nameJoiner = new NameJoiner();

            nameJoiner.Join("Sarah", "Smith").ShouldStartWith("Smith");
        }

        [Fact]
        public void ShouldEndWithLastName()
        {
            var nameJoiner = new NameJoiner();

            nameJoiner.Join("Sarah", "Smith").ShouldEndWith("Smith");
        }

        [Fact]
        public void ShouldMatchRegularExpression()
        {
            var nameJoiner = new NameJoiner();

            nameJoiner.Join("Sarah", "Smith").ShouldMatch("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+");
        }
    }
}