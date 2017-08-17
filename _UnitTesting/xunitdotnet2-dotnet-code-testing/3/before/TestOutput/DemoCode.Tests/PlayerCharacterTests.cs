using System;
using System.Diagnostics;
using Xunit;


namespace DemoCode.Tests
{
    public class PlayerCharacterTests
    {

        [Fact]
        public void ShouldIncreaseHealthAfterSleeping()
        {            
            Console.WriteLine("Creating PlayerCharacter");
            var sut = new PlayerCharacter { Health = 100 };

            Console.WriteLine("PlayerCharacter going to sleep");
            sut.Sleep();
            Console.WriteLine("PlayerCharacter awoken");

            Assert.InRange(sut.Health, 101, 200);
        }


    }
}
