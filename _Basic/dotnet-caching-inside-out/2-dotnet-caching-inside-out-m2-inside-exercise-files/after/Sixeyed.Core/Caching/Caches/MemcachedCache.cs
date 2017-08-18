using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Enyim.Caching;
using Enyim.Caching.Memcached;
using Sixeyed.Core.Logging;

namespace Sixeyed.Core.Caching.Caches
{
    public class MemcachedCache : CacheBase
    {
        private MemcachedClient _cache;

        public override CacheType CacheType
        {
            get { return CacheType.Memcached; }
        }

        public override void Initialise()
        {
            if (_cache == null)
            {
                Log.Debug("MemcachedCache.Initialise - initialising");
                _cache = new MemcachedClient();
            }
        }

        protected override void SetInternal(string key, object value)
        {
            _cache.Store(StoreMode.Set, key, value);
        }

        protected override void SetInternal(string key, object value, DateTime expiresAt)
        {
            _cache.Store(StoreMode.Set, key, value, expiresAt);
        }

        protected override void SetInternal(string key, object value, TimeSpan validFor)
        {
            _cache.Store(StoreMode.Set, key, value, validFor);
        }

        protected override object GetInternal(string key)
        {
            return _cache.Get(key);
        }

        protected override void RemoveInternal(string key)
        {
            if (Exists(key))
            {
                _cache.Remove(key);
            }
        }

        protected override bool ExistsInternal(string key)
        {
            return Get(key) != null;
        }
    }
}
