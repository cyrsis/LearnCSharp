using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDynamic;
using Microsoft.CSharp.RuntimeBinder;
using Xunit;

namespace Tests
{
    public class HtmlElementTests
    {
        [Fact]
        public void ShouldStoreTagName()
        {
            var image = new HtmlElement("img");

            Assert.Equal("img", image.TagName);
        }


        [Fact]
        public void ShouldAddAttributeNameAndValueDynamically()
        {
            dynamic image = new HtmlElement("img");

            image.src = "car.png";

            Assert.Equal("car.png", image.src);
        }


        [Fact]
        public void ShouldErrorIfAttributeNotSet()
        {
            dynamic image = new HtmlElement("img");

            Assert.Throws<RuntimeBinderException>(() => image.src);
        }


        [Fact]
        public void ShouldReturnDynamicMemberNames()
        {
            dynamic image = new HtmlElement("img");

            image.src = "car.png";
            image.alt = "a blue car";

            string[] members = image.GetDynamicMemberNames();

            Assert.Equal(2, members.Length);

            Assert.Equal("src", members[0]);
            Assert.Equal("alt", members[1]);
        }

    }
}
