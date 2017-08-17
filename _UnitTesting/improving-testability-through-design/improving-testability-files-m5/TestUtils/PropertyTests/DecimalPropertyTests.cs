using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUtils.PropertyTests
{
    public static class DecimalPropertyTests
    {

        public static readonly decimal SmallestPositiveDecimal = 1e-28M;
        
        public static void TestDecimalPositiveProperty(object obj, string propName)
        {
            string[] errors = new string[]
            {
                PropertyTestUtils.TestSetterFailure(obj, propName, -1.2M, typeof(ArgumentException)),
                PropertyTestUtils.TestSetterFailure(obj, propName, 0.0M, typeof(ArgumentException)),
                PropertyTestUtils.SafeTestGetterSetter(obj, propName, SmallestPositiveDecimal),
                PropertyTestUtils.SafeTestGetterSetter(obj, propName, 3.4M)
            };

            AssertNoErrors(errors);

        }

        private static void AssertNoErrors(string[] errors)
        {
            string message = string.Empty;

            foreach (string error in errors)
                if (!string.IsNullOrEmpty(error))
                    message = message + Environment.NewLine + "----> " + error;

            Assert.IsTrue(string.IsNullOrEmpty(message), message);
        }

    }
}
