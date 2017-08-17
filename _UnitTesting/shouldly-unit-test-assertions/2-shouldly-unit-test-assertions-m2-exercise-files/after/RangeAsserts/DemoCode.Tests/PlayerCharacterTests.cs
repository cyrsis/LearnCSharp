using Xunit;
using Shouldly;

namespace DemoCode.Tests
{   
    public class PlayerCharacterTests
    {
        [Fact]
        public void ShouldGainHealthAfterSleeping()
        {
            var playerCharacter = new PlayerCharacter { Health = 100 };

            playerCharacter.Sleep();

            // playerCharacter.Health.ShouldBeGreaterThan(100);
            // playerCharacter.Health.ShouldBeLessThanOrEqualTo(200);

            playerCharacter.Health.ShouldBeInRange(101, 200);
        }

    }
}
