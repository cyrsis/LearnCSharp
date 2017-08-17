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

            var dataAttributes = 
                testMethod.GetCustomAttributes<TestCaseDataAttribute>();


            foreach (var testCaseDataAttribute in dataAttributes)
            {
                testCases.Add(testCaseDataAttribute.TestCaseParameters);
            }

            return testCases;
        }
    }
}
