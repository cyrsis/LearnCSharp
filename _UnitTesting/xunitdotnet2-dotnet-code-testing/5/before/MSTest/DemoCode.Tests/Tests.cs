using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoCode.Tests
{
    [TestClass]
    public class TestMethods
    {
        [TestMethod]
        public void ShouldNotHaveANickName()
        {
            var sut = new PlayerCharacter();

            Assert.IsNull(sut.NickName);
        }

        [TestMethod]
        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();

            Assert.IsTrue(sut.IsNoob);
        }

        [TestMethod]
        public void ShouldAddIntValues()
        {
            var sut = new Calculator();

            var result = sut.AddInts(1, 2);

            Assert.AreEqual(3, result);
        }
    }
}
