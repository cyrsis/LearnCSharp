using Xunit;

namespace Demo.Tests
{
    public class NullGuardExamples
    {
        [Fact]
        public void NullProperty()
        {
            var p = new Person();

            p.FirstName = null;
        }


        [Fact]
        public void NullMethodParam()
        {
            var p = new Person();

            p.DoSomething(null);
        }


        [Fact]
        public void AllowOnlySpecificPropertyToAllowNull()
        {
            var p = new Person();

            p.FirstName = null;
        }


        [Fact]
        public void AllowOnlySpecificMethodParamToAllowNull()
        {
            var p = new Person();

            p.DoSomething(null);
        }


        [Fact]
        public void MethodsReturningNulls()
        {
            var p = new Person();

            var returnValue = p.SomeMethod();
        }
    }
}
