using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TestUtils.Constructors
{
    public class SuccessTest<T>: TestCase<T>
    {
        private Func<T, bool> validator;

        public SuccessTest(ConstructorInfo ctor, object[] args,
                           Func<T, bool> validator, string failMessage)
            : base(ctor, args, failMessage)
        {
            this.validator = validator;
        }

        public override string Execute()
        {
            try
            {
                T obj = base.InvokeConstructor();
                if (!this.validator(obj))
                    return base.Fail("Validation failed.");
            }
            catch (System.Exception ex)
            {
                return base.Fail(string.Format("{0} occurred: {1}",
                                               ex.GetType().Name, ex.Message));
            }

            return base.Success();

        }
    }
}
