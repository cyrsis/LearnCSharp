using System;
using System.Diagnostics;
using Fixie;

namespace DemoCode.Tests
{
    internal class CustomConvention : Convention
    {
        public CustomConvention()
        {
            Classes.NameEndsWith("Checks");

            Methods.Where(method => method.IsPublic || method.IsAsync());

            CaseExecution.Wrap<CustomCaseExecutionBehaviour>();

            FixtureExecution.Wrap<CustomFixtureExecutionBehaviour>();
        }
    }

    internal class CustomCaseExecutionBehaviour : CaseBehavior
    {
        public void Execute(Case context, Action next)
        {
            Debug.WriteLine("           Case Before " + context.Method);

            next();

            Debug.WriteLine("           Case after " + context.Method);
        }
    }


    internal class CustomFixtureExecutionBehaviour : FixtureBehavior
    {
        public void Execute(Fixture context, Action next)
        {
            Debug.WriteLine("   Fixture Before");

            next();

            Debug.WriteLine("   Fixture After");
        }
    }


}