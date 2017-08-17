using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace TestUtils.PropertyTests
{
    public static class PropertyTestUtils
    {

        public static string TestGetterSetter<T>(object obj, string propName, T value)
        {

            PropertyInfo property = obj.GetType().GetProperty(propName);

            try
            {
                property.SetValue(obj, value);
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException;
            }

            T outValue = (T)property.GetValue(obj);

            string error = string.Empty;

            if (!value.Equals(outValue))
            {
                error = string.Format("{0} getter returned {1} when expecting {2}.",
                                      propName, outValue, value);
            }

            return error;
        }

        public static string TestSetterFailure<T>(object obj, string propName, T value,
                                                  Type exceptionType)
        {
            string error = string.Empty;

            try
            {
                TestGetterSetter<T>(obj, propName, value);
                error = string.Format("No exception thrown when setting {0}={1}. {2} was expected.",
                                      propName, value, exceptionType.Name);
            }
            catch (System.Exception ex)
            {
                if (exceptionType != ex.GetType())
                {
                    error = string.Format("{0} thrown when {1} was expected on setting {2}={3}: {4}",
                                          ex.GetType().Name, exceptionType.Name,
                                          propName, value, ex.Message);
                }
            }

            return error;
        }

        public static string SafeTestGetterSetter<T>(object obj, string propName, T value)
        {
            string error = string.Empty;

            try
            {
                error = TestGetterSetter<T>(obj, propName, value);
            }
            catch (System.Exception ex)
            {
                error = string.Format("Error setting {0}={1}: {2}", propName, value, ex.Message);
            }

            return error;

        }

    }
}
