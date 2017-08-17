using System;
using Should;

namespace DemoCode.Tests
{
    public class PlayerCharacterSetupTeardownTests : IDisposable
    {
        private PlayerCharacter sut;

        public PlayerCharacterSetupTeardownTests()
        {
            sut = new PlayerCharacter();
        }

        public void ShouldHaveALongBow()
        {
            sut.Weapons.ShouldContain("Long Bow");
        }


        public void ShouldHaveNoEmptyDefaultWeapons()
        {
            sut.Weapons.ShouldNotContain(String.Empty);
        }


        public void ShouldNotHaveAStaffOfWonder()
        {
            sut.Weapons.ShouldNotContain("Staff Of Wonder");
        }

        public void Dispose()
        {
            // cleanup code after each test executes
        }

    }
}
