using Should;

namespace DemoCode.Tests
{
    class NameJoinerTests
    {
        public void ShouldJoinNames()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            fullName.ShouldEqual("Sarah Smith");
        }

        public void StringInequality()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            fullName.ShouldNotEqual("Gentry Smith");
        }


        public void StringContains()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            fullName.ShouldContain("Smith");
        }


        public void StringDoesNotContain()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            fullName.ShouldNotContain("Gentry");
        }


        public void StringNotEmpty()
        {
            var sut = new NameJoiner();

            var fullName = sut.Join("Sarah", "Smith");

            fullName.ShouldNotBeEmpty();
        } 
    }
}
