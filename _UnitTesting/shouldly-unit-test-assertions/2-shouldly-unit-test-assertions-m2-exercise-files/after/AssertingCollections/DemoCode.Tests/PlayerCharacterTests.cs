using Xunit;
using Shouldly;

namespace DemoCode.Tests
{   
    public class PlayerCharacterTests
    {
        [Fact]
        public void ShouldHaveAtLeastOneWeapon()
        {
            var playerCharacter = new PlayerCharacter();

            playerCharacter.Weapons.ShouldNotBeEmpty();
        }

        [Fact]
        public void ShouldNotHaveAnyEmptyWeapons()
        {
            var playerCharacter = new PlayerCharacter();

            playerCharacter.Weapons.ShouldAllBe(weapon => !string.IsNullOrWhiteSpace(weapon));
        }


        [Fact]
        public void ShouldHaveALongBow()
        {
            var playerCharacter = new PlayerCharacter();

            playerCharacter.Weapons.ShouldContain("Long Bow");
        }


        [Fact]
        public void ShouldNotHaveAStaffOfWonder()
        {
            var playerCharacter = new PlayerCharacter();

            playerCharacter.Weapons.ShouldNotContain("Staff Of Wonder");
        }

        [Fact]
        public void ShouldNotHaveTwoOfTheSameWeapon()
        {
            var playerCharacter = new PlayerCharacter();

            playerCharacter.Weapons.ShouldBeUnique();
        }
    }
}
