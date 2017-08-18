using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Core.Extensions;
using System.Threading;
using Sixeyed.Core.Caching;
using Sixeyed.Core.Tests.Stubs;

namespace Sixeyed.Core.Tests.Caching
{
    [TestClass]
    public class AppFabricCacheTests
    {
        ICache _cache;

        public AppFabricCacheTests()
        {
            _cache = Cache.AppFabric;
        }

        [TestMethod]
        public void Set()
        {
            var key = Guid.NewGuid().ToString();
            var value = StubRequest.GetRequest();
            _cache.Set(key, value);
            Assert.IsTrue(_cache.Exists(key));
            var retrievedValue = _cache.Get<StubRequest>(key);
            Assert.AreEqual(value.CreatedOn, retrievedValue.CreatedOn);
            Assert.AreEqual(value.Id, retrievedValue.Id);
            Assert.AreEqual(value.Name, retrievedValue.Name);
        }

        [TestMethod]
        public void Set_WithAbsoluteExpiry()
        {            
            var key = Guid.NewGuid().ToString();
            var value = StubRequest.GetRequest();
            var expiresAt = DateTime.Now.AddMilliseconds(250);
            _cache.Set(key, value, expiresAt);
            Assert.IsTrue(_cache.Exists(key));
            Thread.Sleep(2000);
            Assert.IsFalse(_cache.Exists(key));
        }

        [TestMethod]
        public void Set_WithSlidingExpiry()
        {
            var key = Guid.NewGuid().ToString();
            var value = StubRequest.GetRequest();
            var lifespan = new TimeSpan(0, 0, 0, 0, 250);
            _cache.Set(key, value, lifespan);
            Assert.IsTrue(_cache.Exists(key));
            Thread.Sleep(200);
            var retrieved = _cache.Get(key);
            Assert.IsNotNull(retrieved);
            Thread.Sleep(200);
            retrieved = _cache.Get(key);
            Assert.IsNotNull(retrieved);
            Thread.Sleep(2000);
            Assert.IsFalse(_cache.Exists(key));
        }

        [TestMethod]
        public void Set_ThenRemove()
        {
            var key = Guid.NewGuid().ToString();
            var value = StubRequest.GetRequest();
            _cache.Set(key, value);
            Assert.IsTrue(_cache.Exists(key));
            _cache.Remove(key);
            Assert.IsFalse(_cache.Exists(key));
        }
    }
}
