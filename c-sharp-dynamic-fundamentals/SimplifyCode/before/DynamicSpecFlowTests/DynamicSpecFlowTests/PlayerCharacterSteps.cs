using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace DynamicSpecFlowTests
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private PlayerCharacter _player;

        [Given(@"I'm a new player")]
        public void GivenImANewPlayer()
        {
            _player = new PlayerCharacter();
        }

        [When("I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            _player.Hit(damage);
        }

        [Then(@"My health should now be (.*)")]
        public void ThenMyHealthShouldNowBe(int expectedHealth)
        {
            Assert.Equal(expectedHealth, _player.Health);
        }     

        [Given(@"I have the following attributes")]
        public void GivenIHaveTheFollowingAttributes(Table table)
        {
            // non-dynamic version
            string race = table.Rows.First(row => row["attribute"] == "Race")["value"];
            string resistance = table.Rows.First(row => row["attribute"] == "Resistance")["value"];

            _player.Race = race;
            _player.DamageResistance = int.Parse(resistance);
        }

    }
}
