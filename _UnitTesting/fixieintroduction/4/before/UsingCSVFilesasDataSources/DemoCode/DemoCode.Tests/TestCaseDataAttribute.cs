using System;

namespace DemoCode.Tests
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class TestCaseDataAttribute : Attribute
    {
        public TestCaseDataAttribute(params object[] testCaseParameters)
        {
            TestCaseParameters = testCaseParameters;
        }

        public object[] TestCaseParameters { get; private set; }
    }
}
