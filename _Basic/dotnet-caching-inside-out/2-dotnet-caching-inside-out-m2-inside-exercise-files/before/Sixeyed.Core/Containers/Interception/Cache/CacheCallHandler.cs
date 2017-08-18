using System.Reflection;
using Sixeyed.Core.Caching;
using Sixeyed.Core.Configuration;
using Sixeyed.Core.Serialization;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace Sixeyed.Core.Containers.Interception.Cache
{
    /// <summary>
    /// <see cref="ICallHandler"/> for intercepting method calls and caching the responses
    /// </summary>
    public class CacheCallHandler : ICallHandler
    {
        /// <summary>
        /// Order which the handler should fire
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Returns previously cached response or invokes method and caches response
        /// </summary>
        /// <param name="input"></param>
        /// <param name="getNext"></param>
        /// <returns></returns>
        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {            
            //if caching is disabled, leave:
            if (!CacheConfiguration.Current.Enabled)
            {
                return Proceed(input, getNext);
            }

            //get the cache settings from the attribute & config:
            var cacheAttribute = GetCacheSettings(input);
            if (cacheAttribute.Disabled)
            {
                return Proceed(input, getNext);
            }

            //if there's no cache provider, leave:
            var cache = Caching.Cache.Get(cacheAttribute.CacheType);
            var serializer = Serializer.GetCurrent(cacheAttribute.SerializationFormat);
            if (cache == null || cache.CacheType == CacheType.Null || serializer == null)
            {
                return Proceed(input, getNext);
            }            

            var returnType = ((MethodInfo)input.MethodBase).ReturnType;
            var cacheKey = CacheKeyBuilder.GetCacheKey(input, serializer);            
            var cachedValue = cache.Get(cacheKey);
            if (cachedValue == null)
            {                
                //call the intended method to set the return value
                var methodReturn = Proceed(input, getNext);
                //only cache if we have a real return value & no exception:
                if (methodReturn != null && methodReturn.ReturnValue != null && methodReturn.Exception == null)
                {
                    var cacheValue = serializer.Serialize(methodReturn.ReturnValue);
                    var lifespan = cacheAttribute.Lifespan;
                    if (lifespan.TotalSeconds > 0)
                    {
                        cache.Set(cacheKey, cacheValue, lifespan);
                    }
                    else
                    {
                        cache.Set(cacheKey, cacheValue);
                    }
                }
                return methodReturn;
            }
            var returnValue = serializer.Deserialize(returnType, cachedValue);
            return input.CreateMethodReturn(returnValue);
        }

        private static CacheAttribute GetCacheSettings(IMethodInvocation input)
        {
            //get the cache attribute & check if overridden in config:
            var attributes = input.MethodBase.GetCustomAttributes(typeof(CacheAttribute), false);            
            var cacheAttribute = (CacheAttribute)attributes[0];
            var cacheKeyPrefix = CacheKeyBuilder.GetCacheKeyPrefix(input);
            var targetConfig = CacheConfiguration.Current.Targets[cacheKeyPrefix];
            if (targetConfig != null)
            {
                cacheAttribute.Disabled = !targetConfig.Enabled;
                cacheAttribute.Days = targetConfig.Days;
                cacheAttribute.Hours = targetConfig.Hours;
                cacheAttribute.Minutes = targetConfig.Minutes;
                cacheAttribute.Seconds = targetConfig.Seconds;
                cacheAttribute.CacheType = targetConfig.CacheType;
                cacheAttribute.SerializationFormat = targetConfig.SerializationFormat;
            }
            if (cacheAttribute.SerializationFormat == SerializationFormat.Null)
            {
                cacheAttribute.SerializationFormat = CacheConfiguration.Current.DefaultSerializationFormat;
            }
            if (cacheAttribute.CacheType == CacheType.Null)
            {
                cacheAttribute.CacheType = CacheConfiguration.Current.DefaultCacheType;
            }
            return cacheAttribute;
        }

        private static IMethodReturn Proceed(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            return getNext()(input, getNext);
        }       
    }
}
