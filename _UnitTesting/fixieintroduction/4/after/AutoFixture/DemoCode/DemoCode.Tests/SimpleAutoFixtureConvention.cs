using Fixie;

namespace DemoCode.Tests
{
    class SimpleAutoFixtureConvention : Convention
    {
        public SimpleAutoFixtureConvention()
        {
            Classes.NameEndsWith("Tests");

            Methods.Where(method => method.IsPublic || method.IsAsync());

            Parameters.Add<SimpleAutoFixtureParameterSource>();            
        }
    }
}