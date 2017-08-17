using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Fixie;

namespace DemoCode.Tests
{
    class SimpleParameterSource : ParameterSource
    {
        public IEnumerable<object[]> GetParameters(MethodInfo method)
        {
            var testCases = new List<object[]>();

            testCases.Add(new object[] { 1, 2, 3 });
            testCases.Add(new object[] { -10, -2, -12 });
            testCases.Add(new object[] { 10, -2, 8 });

            return testCases;
        }
    }
}
