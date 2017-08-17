using Should;

namespace DemoCode.Tests
{
    class EnemyFactoryTests
    {
        public void ShouldCreateNormalEnemy()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(false);

            enemy.ShouldBeType<NormalEnemy>();
        }

        public void ShouldCreateBossEnemy()
        {
            var sut = new EnemyFactory();

            object enemy = sut.Create(true);

            enemy.ShouldBeType<BossEnemy>();
        }
    }
}
