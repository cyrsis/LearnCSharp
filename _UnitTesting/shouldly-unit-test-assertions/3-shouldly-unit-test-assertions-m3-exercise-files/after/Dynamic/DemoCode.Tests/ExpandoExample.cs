using System;
using System.Dynamic;
using Xunit;
using Shouldly;

namespace DemoCode.Tests
{   
    public class ExpandoExampleDemo
    {
        [Fact] 
        public void ShouldHaveProperty()
        {
            dynamic person = new ExpandoObject();

            person.FirstName = "Sarah";

            DynamicShould.HaveProperty(person, "Name");
        }

    }
}
