using Xunit;
using Shouldly;

namespace DemoCode.Tests
{   
    public class PlayerCharacterTests
    {
        [Fact]
        private void ShouldBeNoobByDefault()
        {
            var playerCharacter = new PlayerCharacter();

            playerCharacter.IsNoob.ShouldBe(true);
        }

        [Fact]
        private void ShouldHaveADefaultName()
        {
            var playerCharacter = new PlayerCharacter();

            playerCharacter.Name.ShouldNotBe(null);
        }

        [Fact]
        private void ShouldHaveANonEmptyDefaultName()
        {
            var playerCharacter = new PlayerCharacter();

            playerCharacter.Name.ShouldBeNullOrEmpty();
        }

    }
}
