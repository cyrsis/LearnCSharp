using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeopleViewer.Test
{
    [TestClass]
    public class MainViewModelTest
    {
        [TestMethod]
        public void People_OnFetchData_IsPopulated()
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
        public void RepositoryType_OnCreation_ReturnsFakeRepositoryString()
        {
            // Arrange / Act
            var viewModel = new MainViewModel();
            var expectedString = "PersonRepository.Fake.FakeRepository";

            // Assert
            Assert.AreEqual(expectedString, viewModel.RepositoryType);
        }
    }
}
