using Xunit;
using Shouldly;

namespace DemoCode.Tests
{
    public class PlayerCharacterTests
    {
        [Fact]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {
            var playerCharacter = new PlayerCharacter();

            Assert.All(playerCharacter.Weapons, weapon => Assert.False(string.IsNullOrWhiteSpace(weapon)));
        }

        [Fact]
        public void ShouldHaveALongBow()
        {
            var playerCharacter = new PlayerCharacter();

            Assert.Contains("Long Bow", playerCharacter.Weapons);
        }

        [Fact]
        public void ShouldNotHaveAStaffOfWonder()
        {
            var playerCharacter = new PlayerCharacter();

            // Assert.DoesNotContain("Staff Of Wonder", playerCharacter.Weapons);     
            playerCharacter.Weapons.ShouldNotContain("Staff Of Wonder");
        }


        [Fact]
        public void ShouldHaveAtLeastOneKindOfSword()
        {
            var playerCharacter = new PlayerCharacter();

            Assert.Contains(playerCharacter.Weapons, weapon => weapon.Contains("Sword"));
        }
    }
}
