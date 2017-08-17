using Fixie;

namespace DemoCode.Tests.Calculator
{
    class CustomCalculatorConvention : Convention
    {
        public CustomCalculatorConvention()
        {
            Classes.NameEndsWith("Checks");

            Methods.Where(method => method.IsPublic || method.IsAsync());           
        }
    }         
}
