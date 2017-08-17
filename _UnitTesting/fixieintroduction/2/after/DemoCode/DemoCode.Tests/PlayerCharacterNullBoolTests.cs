using Should;

namespace DemoCode.Tests
{
    class PlayerCharacterNullBoolTests
    {
        public void ShouldNotHaveANickName()
        {
            var sut = new PlayerCharacter();

            sut.NickName.ShouldBeNull();
        }

        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();

            sut.IsNoob.ShouldBeTrue();
        }
    }
}
