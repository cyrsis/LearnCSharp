using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TestUtils.Constructors
{
    public abstract class TestCase<T>
    {
        private ConstructorInfo constructor;
        private object[] arguments;
        private string failMessage;

        public TestCase(ConstructorInfo ctor, object[] args, string failMessage)
        {
            this.constructor = ctor;
            this.arguments = args;
            this.failMessage = failMessage;
        }

        public abstract string Execute();

        protected T InvokeConstructor()
        {
            try
            {
                return (T)this.constructor.Invoke(this.arguments);
            }
            catch (TargetInvocationException ex)
            {
                throw ex.InnerException;
            }
        }

        protected string Fail(string message)
        {
            return string.Format("Test failed ({0}): {1}", this.failMessage, message);
        }

        protected string Success()
        {
            return string.Empty;
        }
    }
}
