using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Core.Extensions;
using System.Threading;
using Sixeyed.Core.Caching;
using Sixeyed.Core.Tests.Stubs;

namespace Sixeyed.Core.Tests.Caching
{
    [TestClass]
    public class MemcachedTests
    {
        [TestMethod]
        public void Set()
        {
            var key = Guid.NewGuid().ToString();
            var value = StubRequest.GetRequest();
            Cache.Memcached.Set(key, value);
            Assert.IsTrue(Cache.Memcached.Exists(key));
            var retrievedValue = Cache.Memcached.Get<StubRequest>(key);
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
            Cache.Memcached.Set(key, value, expiresAt);
            Assert.IsTrue(Cache.Memcached.Exists(key));
            Thread.Sleep(2000);
            Assert.IsFalse(Cache.Memcached.Exists(key));
        }

        [TestMethod]
        public void Set_WithSlidingExpiry()
        {
            var key = Guid.NewGuid().ToString();
            var value = StubRequest.GetRequest();
            var lifespan = new TimeSpan(0, 0, 0, 0, 250);
            Cache.Memcached.Set(key, value, lifespan);
            Assert.IsTrue(Cache.Memcached.Exists(key));
            Thread.Sleep(200);
            var retrieved = Cache.Memcached.Get(key);
            Assert.IsNotNull(retrieved);
            Thread.Sleep(200);
            retrieved = Cache.Memcached.Get(key);
            Assert.IsNotNull(retrieved);
            Thread.Sleep(2000);
            Assert.IsFalse(Cache.Memcached.Exists(key));
        }

        [TestMethod]
        public void Set_ThenRemove()
        {
            var key = Guid.NewGuid().ToString();
            var value = StubRequest.GetRequest();
            Cache.Memcached.Set(key, value);
            Assert.IsTrue(Cache.Memcached.Exists(key));
            Cache.Memcached.Remove(key);
            Assert.IsFalse(Cache.Memcached.Exists(key));
        }
    }
}
