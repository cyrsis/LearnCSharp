using System;
using System.Collections.Generic;
using System.Reflection;
using Fixie;
using Ploeh.AutoFixture.Kernel;

namespace DemoCode.Tests
{
    internal class SimpleAutoFixtureParameterSource : ParameterSource
    {
        public IEnumerable<object[]> GetParameters(MethodInfo testMethod)
        {   
            var parameterValues = new List<object>();

            foreach (var parameterInfo in testMethod.GetParameters())
            {
                var testMethodParamType = parameterInfo.ParameterType;

                var anonymousValue = CreateAutoFixtureObjectFromType(testMethodParamType);

                parameterValues.Add(anonymousValue);
            }

            return new[] { parameterValues.ToArray() };            
        }


        /// <summary>
        /// Helper method to allow AutoFixture creation where type not known
        /// </summary>
        private object CreateAutoFixtureObjectFromType(Type typeToCreate)
        {
            return new SpecimenContext(new Ploeh.AutoFixture.Fixture()).Resolve(typeToCreate);
        } 
    }
}