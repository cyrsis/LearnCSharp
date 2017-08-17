using System;
using Xunit;
using Shouldly;

namespace DemoCode.Tests
{
    public class EnemyFactoryTests
    {
        [Fact]
        public void ShouldCreateBossEnemy()
        {
            var factory = new EnemyFactory();

            object boss = factory.Create(true);

            boss.ShouldBeAssignableTo<Enemy>();

        }


        [Fact]
        public void ShouldCreateBossEnemyWithCorrectPower()
        {
            var factory = new EnemyFactory();

            object boss = factory.Create(true);

            BossEnemy bossEnemy = boss.ShouldBeOfType<BossEnemy>();

            bossEnemy.ExtraPower.ShouldBe(42);
        }



    }
}

