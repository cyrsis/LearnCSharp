using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode.Tests
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    class TestCaseDataAttribute : Attribute
    {
        public TestCaseDataAttribute(params object[] testCaseParameters)
        {
            TestCaseParameters = testCaseParameters;
        }

        public object[] TestCaseParameters { get; private set; }
    }
}
