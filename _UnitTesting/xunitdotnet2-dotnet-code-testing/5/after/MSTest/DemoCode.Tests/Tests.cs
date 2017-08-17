using Xunit;

namespace DemoCode.Tests
{
    public class TestMethods
    {
        [Fact]
        public void ShouldNotHaveANickName()
        {
            var sut = new PlayerCharacter();

            Assert.Null(sut.NickName);
        }

        [Fact]
        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }

        [Fact]
        public void ShouldAddIntValues()
        {
            var sut = new Calculator();

            var result = sut.AddInts(1, 2);

            Assert.Equal(3, result);
        }
    }
}
