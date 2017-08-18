using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sixeyed.CarValet.Entities;
using Sixeyed.CarValet.Entities.Spec;
using Sixeyed.Core.Caching;
using Sixeyed.Core.Containers;
using Sixeyed.Core.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace Sixeyed.CarValet.Services.Tests
{
    [TestClass]
    public class VehicleServiceTests
    {
        [TestMethod]
        public void SearchMakes_WithMockCache()
        {
            var makes = new List<Make>();
            var jsonMakes = Serializer.Json.Serialize(makes);

            var mockCache = new Mock<ICache>();
            mockCache.Setup(x => x.CacheType)
                     .Returns(CacheType.Memory);
            mockCache.SetupSequence(x => x.Get(It.IsAny<string>()))
                     .Returns(null)
                     .Returns(jsonMakes)
                     .Returns(jsonMakes);

            Container.RegisterInstance<ICache>(mockCache.Object, Lifetime.Singleton);

            var service = new VehicleService();

            var response = service.SearchMakes("au");
            mockCache.Verify(x => x.Get(It.IsAny<string>()), Times.Once());
            mockCache.Verify(x => x.Set(It.IsAny<string>(), It.IsAny<object>()), Times.Once());

            response = service.SearchMakes("au");
            mockCache.Verify(x => x.Get(It.IsAny<string>()), Times.Exactly(2));
            mockCache.Verify(x => x.Set(It.IsAny<string>(), It.IsAny<object>()), Times.Once());

            response = service.SearchMakes("vo");
            mockCache.Verify(x => x.Get(It.IsAny<string>()), Times.Exactly(3));
            mockCache.Verify(x => x.Set(It.IsAny<string>(), It.IsAny<object>()), Times.Once());
        }

        [TestMethod]
        public void SearchMakes_WithMockDataContext()
        {
            var makes = new List<Make>();
            makes.Add(new Make() { MakeCode = "AU", MakeName = "Audi", MakeNameLower = "audi" });
            makes.Add(new Make() { MakeCode = "VO", MakeName = "Volvo", MakeNameLower = "volvo" });

            var mockContext = new Mock<IVehicleEntities>();
            mockContext.Setup(x => x.Makes)
                       .Returns(makes);

            Container.RegisterInstance<IVehicleEntities>(mockContext.Object, Lifetime.Singleton);

            var service = new VehicleService();
            mockContext.Verify(x => x.Makes, Times.Never());

            var response = service.SearchMakes("au");
            Assert.AreEqual(1, response.Count());
            Assert.AreEqual("Audi", response.ElementAt(0));
            mockContext.Verify(x => x.Makes, Times.Once());

            response = service.SearchMakes("au");
            Assert.AreEqual(1, response.Count());
            Assert.AreEqual("Audi", response.ElementAt(0));
            mockContext.Verify(x => x.Makes, Times.Once());

            response = service.SearchMakes("vo");
            Assert.AreEqual(1, response.Count());
            Assert.AreEqual("Volvo", response.ElementAt(0));
            mockContext.Verify(x => x.Makes, Times.Once());
        }
    }
}
