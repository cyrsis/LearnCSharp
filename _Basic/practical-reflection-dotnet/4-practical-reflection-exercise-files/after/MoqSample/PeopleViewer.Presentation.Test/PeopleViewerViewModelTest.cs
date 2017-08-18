using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using PersonRepository.Interface;
using System.Collections.Generic;
using PeopleViewer.SharedObjects;
using Moq;

namespace PeopleViewer.Presentation.Test
{
    [TestClass]
    public class PeopleViewerViewModelTest
    {
        IPersonRepository _repository;

        [TestInitialize]
        public void Setup()
        {
            var people = new List<Person>()
            {
                new Person() {FirstName = "John", LastName = "Smith",
                              Rating = 7, StartDate = DateTime.Parse("10/01/2000")},
                new Person() {FirstName = "Mary", LastName = "Thomas",
                              Rating = 9, StartDate = DateTime.Parse("07/23/1971")},
            };

            var repoMock = new Mock<IPersonRepository>();
            repoMock.Setup(r => r.GetPeople()).Returns(people);
            repoMock.Setup(r => r.GetPerson(It.IsAny<string>()))
                .Returns((string n) => people.FirstOrDefault(p => p.LastName == n));
            _repository = repoMock.Object;
        }

        [TestMethod]
        public void People_OnRefreshCommand_IsPopulated()
        {
            // Arrange
            var vm = new PeopleViewerViewModel(_repository);

            // Act
            vm.RefreshPeopleCommand.Execute(null);

            // Assert
            Assert.IsNotNull(vm.People);
            Assert.AreEqual(2, vm.People.Count());
        }

        [TestMethod]
        public void People_OnClearCommand_IsEmpty()
        {
            // Arrange
            var vm = new PeopleViewerViewModel(_repository);
            vm.RefreshPeopleCommand.Execute(null);
            Assert.AreEqual(2, vm.People.Count(), "Invalid Arrangement");

            // Act
            vm.ClearPeopleCommand.Execute(null);

            // Assert
            Assert.AreEqual(0, vm.People.Count());
        }
    }
}
