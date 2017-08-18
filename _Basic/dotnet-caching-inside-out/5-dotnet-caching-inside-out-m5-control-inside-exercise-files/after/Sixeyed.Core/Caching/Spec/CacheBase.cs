using Sixeyed.Core.Configuration;
using Sixeyed.Core.Logging;
using System;

namespace Sixeyed.Core.Caching
{
    public abstract class CacheBase : ICache
    {
        private static NullCache _nullCache = new NullCache();
        private CacheBase _current;

        protected CacheBase Current
        {
            get { return CacheConfiguration.Current.Enabled ? this : _nullCache; }
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

        public void Set(string key, object value, DateTime expiresAt)
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

        public object Get(string key)
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

        public void Remove(string key)
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
    }
}
