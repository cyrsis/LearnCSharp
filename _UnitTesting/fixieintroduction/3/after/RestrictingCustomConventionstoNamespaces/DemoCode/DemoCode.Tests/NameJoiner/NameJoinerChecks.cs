using Should;

namespace DemoCode.Tests.NameJoiner
{
    public class NameJoinerChecks
    {
        public void ShouldJoinNames()
        {        
            var sut = new DemoCode.NameJoiner();

            var result = sut.Join("Sarah", "Smith");

            result.ShouldEqual("Sarah Smith");
        }           
    }
}
