using Xunit;

namespace Demo.Tests
{
    public class EmptyStringGuardExamples
    {
        [Fact]
        public void EmptyProperty()
        {
            var p = new Person();

            p.FirstName = "";
        }


        [Fact]
        public void EmptyMethodParam()
        {
            var p = new Person();

            p.DoSomething("");
        }


        [Fact]
        public void AllowOnlySpecificMembersToAllowEmptyStrings()
        {
            var p = new Person();

            p.FirstName = "";
        }



        
        // ValidationFlags
        //      -  None
        //      -  Properties
        //      -  Methods
        //      -  NonPublic
        //      -  AllPublic (Methods | Properties)
        //      -  All = (AllPublic | NonPublic)

    }
}
