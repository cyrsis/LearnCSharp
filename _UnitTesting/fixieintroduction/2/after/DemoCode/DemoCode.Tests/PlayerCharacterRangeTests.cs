using Should;

namespace DemoCode.Tests
{
    class PlayerCharacterRangeTests
    {
        public void ShouldIncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter { Health = 100 };

            sut.Sleep();

            sut.Health.ShouldBeGreaterThan(100);
        }

        // Also available:
        //  .ShouldBeGreaterThanOrEqualTo();
        //  .ShouldBeLessThan();
        //  .ShouldBeLessThanOrEqualTo();

        public void ShouldIncreaseHealthInExpectedRangeAfterSleeping()
        {
            var sut = new PlayerCharacter { Health = 100 };

            sut.Sleep();

            sut.Health.ShouldBeInRange(101, 200);
        }
    }
}
