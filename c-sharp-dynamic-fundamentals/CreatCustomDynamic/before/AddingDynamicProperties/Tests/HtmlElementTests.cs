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

    }
}
