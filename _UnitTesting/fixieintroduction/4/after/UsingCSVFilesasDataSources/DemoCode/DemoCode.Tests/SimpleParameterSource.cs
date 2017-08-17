using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Fixie;

namespace DemoCode.Tests
{
    internal class SimpleParameterSource : ParameterSource
    {
        public IEnumerable<object[]> GetParameters(MethodInfo testMethod)
        {
            var testCases = new List<object[]>();

            var csvDataAttribute = testMethod.GetCustomAttributes<CsvTestCaseDataAttribute>();

            if (!csvDataAttribute.Any())
            {
                return testCases;
            }

            var csvLines = File.ReadLines(csvDataAttribute.First().FileName);

            foreach (var csvLine in csvLines)
            {
                var lineValues = csvLine.Split(',');

                testCases.Add(new object[]
                              {
                                  int.Parse(lineValues[0]),
                                  int.Parse(lineValues[1]),
                                  int.Parse(lineValues[2])
                              });
            }

            return testCases;
        }
    }
}
