using Sixeyed.Core.Containers;
using Sixeyed.Core.Logging;
using System.Linq;
using System;
using Sixeyed.Core.Configuration;

namespace Sixeyed.Core.Caching
{
    public static class Cache
    {
        public static ICache Get(CacheType cacheType)
        {
            ICache cache = new NullCache();
            try
            {
                var caches = Container.GetAll<ICache>();
                cache = (from c in caches
                         where c.CacheType == cacheType
                         select c).Single();
                cache.Initialise();
            }
            catch (Exception ex)
            {
                Log.Warn("Failed to instantiate cache of type: {0}, using null cache. Exception: {1}", cacheType, ex);
                cache = new NullCache();
            }
            return cache;
        }

        public static ICache Default
        {
            get
            {
                return Get(CacheConfiguration.Current.DefaultCacheType);
            }
        }

        public static ICache Memory
        {
            get
            {
                return Get(CacheType.Memory);
            }
        }

        public static ICache NCacheExpress
        {
            get
            {
                return Get(CacheType.NCacheExpress);
            }
        }

        public static ICache AppFabric
        {
            get
            {
                return Get(CacheType.AppFabric);
            }
        }

        public static ICache AzureTableStorage
        {
            get
            {
                return Get(CacheType.AzureTableStorage);
            }
        }

        public static ICache Disk
        {
            get
            {
                return Get(CacheType.Disk);
            }
        }

        public static ICache Memcached
        {
            get
            {
                return Get(CacheType.Memcached);
            }
        }
    }
}
