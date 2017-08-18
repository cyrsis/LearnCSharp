using Sixeyed.Core.Caching.Caches;
using Sixeyed.Core.Configuration;
using Sixeyed.Core.Logging;
using Sixeyed.Core.Serialization;
using System;
using System.Web.Caching;

namespace Sixeyed.Core.Caching
{
    public abstract class CacheBase : OutputCacheProvider, ICache
    {
        private static NullCache _nullCache = new NullCache();
        private CacheBase _current;
        private bool _initialised;

        protected CacheBase Current
        {
            get 
            {
                if (!CacheConfiguration.Current.Enabled)
                {
                    return _nullCache;
                }
                if (!_initialised)
                {
                    Initialise();
                    _initialised = true;
                }
                return this;
            }
        }

        public abstract CacheType CacheType { get; }
        protected abstract void InitialiseInternal();
        protected abstract void SetInternal(string key, object value);
        protected abstract void SetInternal(string key, object value, DateTime expiresAt);
        protected abstract void SetInternal(string key, object value, TimeSpan validFor);
        protected abstract object GetInternal(string key);
        protected abstract void RemoveInternal(string key);
        protected abstract bool ExistsInternal(string key);

        public void Initialise()
        {
            try
            {
                InitialiseInternal();
            }
            catch (Exception ex)
            {
                Log.Error("CacheBase.Initialise - failed, NullCache will be used. CacheName: {0}, Message: {1}", CacheConfiguration.Current.DefaultCacheName, ex.Message);
                _current = _nullCache;
            }
        }

        public void Set(string key, object value)
        {
            try
            {
                Current.SetInternal(key, value);
            }
            catch (Exception ex)
            {
                Log.Warn("CacheBase.Set - failed, item not cached. Message: {0}", ex.Message);
            }
        }

        void ICache.Set(string key, object value, DateTime expiresAt)
        {
            try
            {
                Current.SetInternal(key, value, expiresAt);
            }
            catch (Exception ex)
            {
                Log.Warn("CacheBase.Set - failed, item not cached. Message: {0}", ex.Message);
            }
        }

        public void Set(string key, object value, TimeSpan validFor)
        {
            try
            {
                Current.SetInternal(key, value, validFor);
            }
            catch (Exception ex)
            {
                Log.Warn("CacheBase.Set - failed, item not cached. Message: {0}", ex.Message);
            }
        }

        object ICache.Get(string key)
        {
            object item = null;
            try
            {
                item = Current.GetInternal(key);
            }
            catch (Exception ex)
            {
                Log.Warn("CacheBase.Get - failed, item not cached. Message: {0}", ex.Message);
            }
            return item;
        }

        public override void Remove(string key)
        {
            try
            {
                Current.RemoveInternal(key);
            }
            catch (Exception ex)
            {
                Log.Warn("CacheBase.Remove - failed, item not cached. Message: {0}", ex.Message);
            }
        }

        public bool Exists(string key)
        {
            var exists = false;
            try
            {
                exists = Current.ExistsInternal(key);
            }
            catch (Exception ex)
            {
                Log.Warn("CacheBase.Exists - failed, item not cached. Message: {0}", ex.Message);
            }
            return exists;
        }


        #region OutputCacheProvider

        public override object Add(string key, object entry, DateTime utcExpiry)
        {
            Set(key, entry, utcExpiry);
            return entry;
        }

        public override void Set(string key, object value, DateTime expiresAt)
        {
            try
            {
                var itemBytes = Serializer.Binary.Serialize(value) as byte[];
                var item = new CacheItem() { ItemBytes = itemBytes };
                var serializedItem = Serializer.Json.Serialize(item);
                var cacheKey = CacheKeyBuilder.GetCacheKey(key);
                Current.SetInternal(cacheKey, serializedItem, expiresAt);
            }
            catch (Exception ex)
            {
                Log.Warn("CacheBase.Set - failed, item not cached. Message: {0}", ex.Message);
            }
        }

        public override object Get(string key)
        {
            var cacheKey = CacheKeyBuilder.GetCacheKey(key);
            object item = null;
            try
            {
                var serializedItem = Current.GetInternal(cacheKey);
                if (serializedItem != null)
                {
                    var cacheItem = Serializer.Json.Deserialize(typeof(CacheItem), serializedItem) as CacheItem;
                    item = Serializer.Binary.Deserialize(null, cacheItem.ItemBytes);
                }
            }
            catch (Exception ex)
            {
                Log.Warn("CacheBase.Get - failed, item not cached. Message: {0}", ex.Message);
            }
            return item;
        }

        #endregion
    }
}
