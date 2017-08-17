using Should;

namespace DemoCode.Tests
{   
    public class NameJoinerTests
    {
        public void ShouldJoinName()
        {        
            var sut = new NameJoiner();

            var result = sut.Join("Sarah", "Smith");

            result.ShouldEqual("Sarah Smith");
        }

    }
}
