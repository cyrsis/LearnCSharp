using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PersonRepository.Fake;
using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleViewer.Test
{
    [TestClass]
    public class MockVMTest
    {
        [TestInitialize]
        public void Setup()
        {
            var people = new List<Person>()
            {
                new Person() {FirstName = "John", LastName = "Smith", 
                    Rating = 7, StartDate = new DateTime(2000, 10, 1)},
                new Person() {FirstName = "Mary", LastName = "Thomas", 
                    Rating = 9, StartDate = new DateTime(1971, 7, 23)},
            };

            var mockRepository = new Mock<IPersonRepository>();
            mockRepository.Setup(r => r.GetPeople()).Returns(people);

            SimpleContainer.MapInstance<IPersonRepository>(mockRepository.Object);
        }

        [TestMethod]
        public void People_WithMockOnFetchData_IsPopulated()
        {
            // Arrange
            var viewModel = new MainViewModel();

            // Act
            viewModel.FetchData();

            // Assert
            Assert.IsNotNull(viewModel.People);
            Assert.AreEqual(2, viewModel.People.Count());
        }

        [TestMethod]
        public void RepositoryType_WithMockOnCreation_ReturnsFakeRepositoryString()
        {
            // Arrange / Act
            var viewModel = new MainViewModel();
            var expectedString = "PersonRepository.Fake.FakeRepository";

            // Assert
            Assert.AreNotEqual(expectedString, viewModel.RepositoryType);
        }
    }
}
