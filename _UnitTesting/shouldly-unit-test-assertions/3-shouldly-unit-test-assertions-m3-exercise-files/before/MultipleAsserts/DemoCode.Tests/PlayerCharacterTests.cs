using Xunit;
using Shouldly;

namespace DemoCode.Tests
{   
    public class PlayerCharacterTests
    {
        [Fact]
        public void ShouldCreateDefaultCharacter()
        {
            var playerCharacter = new PlayerCharacter();

            playerCharacter.Name.ShouldNotBeNullOrEmpty();
            playerCharacter.IsNoob.ShouldBe(true);
            playerCharacter.Weapons.ShouldNotBeEmpty();
        }
    }
}
