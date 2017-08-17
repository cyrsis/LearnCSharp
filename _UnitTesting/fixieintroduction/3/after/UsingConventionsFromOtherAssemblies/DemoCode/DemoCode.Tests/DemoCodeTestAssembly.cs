using Fixie;
using Fixie.Conventions;
using SharedTeamConventions;

namespace DemoCode.Tests
{
    class DemoCodeTestAssembly : TestAssembly
    {
        public DemoCodeTestAssembly()
        {
            Apply<DefaultTeamConvention>();
            Apply<DefaultConvention>();
        }

    }
}
