using System.Collections.Generic;
using System.Reflection;
using Fixie;

namespace DemoCode.Tests
{
    internal class SimpleParameterSource : ParameterSource
    {
        public IEnumerable<object[]> GetParameters(MethodInfo testMethod)
        {
            var testCases = new List<object[]>();

            testCases.Add(new object[] { 1, 2, 3 });
            testCases.Add(new object[] { -10, -2, -12 });
            testCases.Add(new object[] { 10, -2, 8 });

            return testCases;
        }
    }
}
