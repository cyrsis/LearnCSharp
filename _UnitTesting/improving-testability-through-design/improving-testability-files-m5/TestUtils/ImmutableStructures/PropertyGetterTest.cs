using System.Reflection;

namespace TestUtils.ImmutableStructures
{
    public class PropertyGetterTest<T>
    {
        private readonly string propertyName;
        private readonly object propertyValue;

        public PropertyGetterTest(string name, object value)
        {
            this.propertyName = name;
            this.propertyValue = value;
        }

        public string Execute(object obj)
        {

            PropertyInfo prop = typeof(T).GetProperty(this.propertyName);

            if (prop == null)
                return string.Format("Property {0} not found.", this.propertyName);

            return TestProperty(prop, obj);

        }

        private string TestProperty(PropertyInfo prop, object obj)
        {
            try
            {
                object value = GetPropertyValue(prop, obj);
                if (!this.propertyValue.Equals(value))
                    return string.Format("Property {0} returned {1} when expecting {2}.", this.propertyName, value, this.propertyValue);
            }
            catch (System.Exception ex)
            {
                return string.Format("Property {0} threw {1}: {2}", this.propertyName, ex.GetType().Name, ex.Message);
            }

            return string.Empty;
        }

        private object GetPropertyValue(PropertyInfo prop, object obj)
        {
            try
            {
                return prop.GetValue(obj, null);
            }
            catch (System.Reflection.TargetInvocationException targetException)
            {
                throw targetException.InnerException;
            }
        }
    }
}
