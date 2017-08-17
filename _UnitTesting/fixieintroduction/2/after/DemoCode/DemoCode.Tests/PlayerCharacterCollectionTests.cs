using System;
using Should;

namespace DemoCode.Tests
{
    class PlayerCharacterCollectionTests
    {
        public void ShouldHaveALongBow()
        {
            var sut = new PlayerCharacter();

            sut.Weapons.ShouldContain("Long Bow");
        }

        public void ShouldHaveNoEmptyDefaultWeapons()
        {
            var sut = new PlayerCharacter();

            sut.Weapons.ShouldNotContain(String.Empty);
        }

        public void ShouldNotHaveAStaffOfWonder()
        {
            var sut = new PlayerCharacter();

            sut.Weapons.ShouldNotContain("Staff Of Wonder");
        }        
    }
}
