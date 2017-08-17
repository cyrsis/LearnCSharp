using Fixie;

namespace DemoCode.Tests.Calculator
{
    class CustomCalculatorConvention : Convention
    {
        public CustomCalculatorConvention()
        {
            Classes.NameEndsWith("Checks")
                .InTheSameNamespaceAs(typeof(CustomCalculatorConvention));

            Methods.Where(method => method.IsPublic);
        }
    }
}
