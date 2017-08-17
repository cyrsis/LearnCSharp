using System;

namespace DemoCode.Tests
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class CsvTestCaseDataAttribute : Attribute
    {
        public CsvTestCaseDataAttribute(string fileName)
        {
            FileName = fileName;
        }

        public string FileName { get; set; }
    }
}
