using System;
using System.Security.Principal;
using NUnit.Framework;
using TestHelperLib;

namespace Demo
{

    // this class will be auto removed because it ends with "Tests"

    [TestFixture]
    internal class PersonTests
    {
        
        [Test]
        public void PersonName()
        {
            var p = new Person {Name = "Sarah"};

            Assert.AreEqual("Sarah", p.Name);
        }


        [Test]
        public void MayUseOtherTestingTools()
        {
            var rhinoMock = Rhino.Mocks.MockRepository.GenerateMock<IPrincipal>();

            var nSub = NSubstitute.Substitute.For<IPrincipal>();

            var moq = new Moq.Mock<IPrincipal>();
        }


        [Test]
        public void ReferenceToTestingLib()
        {
            Assert.IsTrue(DateTestHelper.DateTimeMinDateMeansNull(DateTime.MinValue));
        }
    }
}
