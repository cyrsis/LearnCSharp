﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.Threading;
using CarRental.Business.Entities;
using CarRental.Data.Contracts;
using Core.Common.Contracts;
using Core.Common.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CarRental.Business.Managers.Tests
{
    [TestClass]
    public class InventoryManagerTests
    {
        [TestInitialize]
        public void Initialize()
        {
            GenericPrincipal principal = new GenericPrincipal(
               new GenericIdentity("Miguel"), new string[] { "Administrators", "CarRentalAdmin" });
            Thread.CurrentPrincipal = principal;
        }
        [TestMethod]
        public void UpdateCar_AddNew()
        {
            Car newCar = new Car();
            Car addedCar = new Car() { CarId = 1 };

            Mock<IDataRepositoryFactory> mockDataRepositoryFactory = new Mock<IDataRepositoryFactory>();
            mockDataRepositoryFactory.Setup(mock => mock.GetDataRepository<ICarRepository>().Add(newCar)).Returns(addedCar);

            InventoryManager manager = new InventoryManager(mockDataRepositoryFactory.Object);

            Car updateCarResults = manager.UpdateCar(newCar);

            Assert.IsTrue(updateCarResults == addedCar);
        }

        [TestMethod]
        public void UpdateCar_UpdateExisting()
        {
            Car existingCar = new Car() { CarId = 1 };
            Car updatedCar = new Car() { CarId = 1 };

            Mock<IDataRepositoryFactory> mockDataRepositoryFactory = new Mock<IDataRepositoryFactory>();
            mockDataRepositoryFactory.Setup(mock => mock.GetDataRepository<ICarRepository>().Update(existingCar)).Returns(updatedCar);

            InventoryManager manager = new InventoryManager(mockDataRepositoryFactory.Object);

            Car updateCarResults = manager.UpdateCar(existingCar);

            Assert.IsTrue(updateCarResults == updatedCar);
        }

        [TestMethod]
        public void DeleteCar()
        {
        }

        [TestMethod]
        public void GetCar()
        {
            Car existingCar = new Car() { CarId = 1 };

            Mock<IDataRepositoryFactory> mockDataRepositoryFactory = new Mock<IDataRepositoryFactory>();
            mockDataRepositoryFactory.Setup(mock => mock.GetDataRepository<ICarRepository>().Get(1)).Returns(existingCar);

            InventoryManager manager = new InventoryManager(mockDataRepositoryFactory.Object);

            Car retrievedCar = manager.GetCar(1);

            Assert.IsTrue(retrievedCar == existingCar);
        }

        [TestMethod]
        public void GetAllCars()
        {
            
        }

        [TestMethod]
        public void GetAvailableCars()
        {
            
        }
    }
}
