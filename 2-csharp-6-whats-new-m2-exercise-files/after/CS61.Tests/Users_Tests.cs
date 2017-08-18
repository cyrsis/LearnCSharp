using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS61.Tests
{
    [TestClass]
    public class Users_Tests
    {
        [TestMethod]
        public void User_Creates_An_Id()
        {
            var u1 = new User("sallen");
            Assert.AreNotEqual(Guid.Empty, u1.Id);
        }
    }
}
