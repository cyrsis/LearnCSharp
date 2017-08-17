using System;
using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;


namespace DemoCode.Tests
{
    public class PlayerCharacterTests
    {
        private readonly ITestOutputHelper _testOutput;

        public PlayerCharacterTests(ITestOutputHelper helper)
        {
            _testOutput = helper;
        }

        [Fact]
        public void ShouldIncreaseHealthAfterSleeping()
        {            
            _testOutput.WriteLine("Creating PlayerCharacter");
            var sut = new PlayerCharacter { Health = 100 };

            _testOutput.WriteLine("PlayerCharacter going to sleep");
            sut.Sleep();
            _testOutput.WriteLine("PlayerCharacter awoken");

            Assert.InRange(sut.Health, 101, 200);
        }


    }
}
