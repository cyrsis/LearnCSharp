using System;
using Should;

namespace DemoCode.Tests
{   
    public class StringJoinerTests
    {  
        public void ShouldJoin(string firstName, string secondName)
        {
            var sut = new DemoCode.NameJoiner();

            var result = sut.Join(firstName, secondName);

            result.ShouldEqual(firstName + " " + secondName);
        }


    }
}
