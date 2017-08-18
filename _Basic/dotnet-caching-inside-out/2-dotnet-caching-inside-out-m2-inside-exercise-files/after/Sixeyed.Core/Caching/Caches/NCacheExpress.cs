using System;
using Alachisoft.NCacheExpress.Web.Caching;
using Sixeyed.Core.Configuration;
using Sixeyed.Core.Logging;

namespace Sixeyed.Core.Caching
{
    /// <summary>
    /// <see cref="ICache"/> implementation using NCacheExpress as the backing cache
    /// </summary>
    /// <remarks>
    /// Uses CacheConfiguration setting "defaultCacheName" to determine the cache name.
    /// Defaults to "Sixeyed.Core.Cache" if not set
    /// </remarks>
    public class NCacheExpress : CacheBase
    {
        public DateTime NoAbsoluteExpiry { get; set;}
        public TimeSpan NoSlidingExpiry { get; set; }
        private string _cacheName;

        /// <summary>
        /// Returns the cache type
        /// </summary>
        public override CacheType CacheType
        {
            get { return CacheType.NCacheExpress; }
        }

        protected override void SetInternal(string key, object value)
        {
            NCache.Caches[_cacheName].Insert(key, value, null, NoAbsoluteExpiry, NoSlidingExpiry, CacheItemPriority.Normal);            
        }

        protected override void SetInternal(string key, object value, DateTime expiresAt)
        {
            NCache.Caches[_cacheName].Insert(key, value, null, expiresAt, NoSlidingExpiry, CacheItemPriority.Normal);
        }

        protected override void SetInternal(string key, object value, TimeSpan validFor)
        {
            NCache.Caches[_cacheName].Insert(key, value, null, NoAbsoluteExpiry, validFor, CacheItemPriority.Normal);            
        }

        protected override object GetInternal(string key)
        {
            return NCache.Caches[_cacheName].Get(key);
        }

        protected override void RemoveInternal(string key)
        {
            NCache.Caches[_cacheName].Remove(key);
        }

        protected override bool ExistsInternal(string key)
        {
            return NCache.Caches[_cacheName].Get(key) != null;
        }

        public override void Initialise()
        {
            if (_cacheName == null)
            {
                _cacheName = CacheConfiguration.Current.DefaultCacheName;
                Log.Debug("NCacheExpress.Initialise - initialising with cacheName: {0}", _cacheName);
                NoAbsoluteExpiry = DateTime.MaxValue;
                NoSlidingExpiry = new TimeSpan(0);
                NCache.InitializeCache(_cacheName);
            }
        }
    }
}
