using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TestUtils.ImmutableStructures
{
    public class Tester<T>
    {
        private readonly List<Type> ctorArgumentTypes = new List<Type>();
        private readonly List<object> ctorArguments = new List<object>();
        private readonly List<PropertyGetterTest<T>> propertyTests = new List<PropertyGetterTest<T>>();

        public Tester()
        {
        }

        public Tester(Tester<T> other)
        {
            this.ctorArgumentTypes.AddRange(other.ctorArgumentTypes);
            this.ctorArguments.AddRange(other.ctorArguments);
            this.propertyTests.AddRange(other.propertyTests);
        }

        public Tester<T> ConstructorParameter<A>(A value, string propertyName)
        {
            return this.ConstructorParameter<A>(value).Property<A>(propertyName, value);
        }

        public Tester<T> ConstructorParameter<A>(A value)
        {

            Tester<T> copy = new Tester<T>(this);
            
            copy.ctorArgumentTypes.Add(typeof(A));
            copy.ctorArguments.Add(value);

            return copy;

        }

        public Tester<T> Property<A>(string name, A value)
        {

            Tester<T> copy = new Tester<T>(this);

            copy.propertyTests.Add(new PropertyGetterTest<T>(name, value));

            return copy;

        }

        public void Assert()
        {
            ConstructorInfo ctor = GetConstructor();
            Assert(ctor);
        }

        private ConstructorInfo GetConstructor()
        {
            return typeof(T).GetConstructor(this.ctorArgumentTypes.ToArray());
        }

        private void Assert(ConstructorInfo ctor)
        {
            string errorMessage = Test(ctor);
            bool success = string.IsNullOrEmpty(errorMessage);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(success, errorMessage);
        }

        private string Test(ConstructorInfo ctor)
        {

            if (ctor == null)
                return "Missing constructor.";

            try
            {
                T obj = (T)ctor.Invoke(this.ctorArguments.ToArray());
                return Test(obj);
            }
            catch (System.Reflection.TargetInvocationException targetException)
            {
                return targetException.InnerException.Message;
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }

        }

        private string Test(T obj)
        {
            
            StringBuilder errors = new StringBuilder();

            foreach (PropertyGetterTest<T> test in this.propertyTests)
            {
                string error = test.Execute(obj);
                if (!string.IsNullOrEmpty(error))
                    errors.AppendFormat("\n{0}", error);
            }

            if (errors.Length > 0)
                return "Some property getters failed: " + errors.ToString();

            return string.Empty;

        }

    }
}
