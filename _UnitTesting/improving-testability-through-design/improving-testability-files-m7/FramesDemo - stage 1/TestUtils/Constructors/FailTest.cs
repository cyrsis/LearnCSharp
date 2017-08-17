using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TestUtils.Constructors
{
    public class FailTest<T>: TestCase<T>
    {
        private Type exceptionType;

        public FailTest(ConstructorInfo ctor, object[] args,
                        Type exceptionType, string failMessage)
            : base(ctor, args, failMessage)
        {
            this.exceptionType = exceptionType;
        }

        public override string Execute()
        {
            try
            {
                base.InvokeConstructor();
                return base.Fail(string.Format("{0} not thrown when expected.",
                                                this.exceptionType.Name));
            }
            catch (System.Exception ex)
            {
                if (ex.GetType() != this.exceptionType)
                    return base.Fail(string.Format("{0} thrown when {1} was expected.",
                                                    ex.GetType().Name,
                                                    this.exceptionType.Name));
            }

            return base.Success();
        }
    }
}
