using Fixie;

namespace DemoCode.Tests
{
    class CustomConvention : Convention
    {
        public CustomConvention()
        {
            Classes.NameEndsWith("Tests");

            Methods.Where(method => method.IsPublic || method.IsAsync());
            
        }
    }         
}
