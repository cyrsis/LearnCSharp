using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ApplicationServer.Caching;

namespace Sixeyed.Core.Caching.Caches
{
    public class AppFabricCache : CacheBase
    {
        private DataCacheFactory _factory;
        private DataCache _cache;

        public override CacheType CacheType
        {
            get {return CacheType.AppFabric; }
        }

        public override void Initialise()
        {
            if (_cache == null)
            {
                _factory = new DataCacheFactory();
                _cache = _factory.GetDefaultCache();
            }
        }

        protected override void SetInternal(string key, object value)
        {
            _cache.Put(key, value);
        }

        protected override void SetInternal(string key, object value, DateTime expiresAt)
        {
            SetInternal(key, value, new TimeSpan(expiresAt.Subtract(DateTime.Now).Ticks));
        }

        protected override void SetInternal(string key, object value, TimeSpan validFor)
        {
            _cache.Put(key, value, validFor);
        }

        protected override object GetInternal(string key)
        {
            return _cache.Get(key);
        }

        protected override void RemoveInternal(string key)
        {
            _cache.Remove(key);
        }

        protected override bool ExistsInternal(string key)
        {
            return Get(key) != null;
        }
    }
}
