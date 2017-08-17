using System;
using Fixie;

namespace DemoCode.Tests
{
    class CustomConvention : Convention
    {
        public CustomConvention()
        {
            Classes.NameEndsWith("Tests");

            Methods.Where(method => method.IsPublic || method.IsAsync());

            CaseExecution.Skip(testCase => testCase.Method.Has<SkipTestAttribute>());
        }
    }

    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class SkipTestAttribute : Attribute
    {
    }

}
