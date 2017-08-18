
namespace Sixeyed.Core.Caching
{
    public enum CacheType
    {
        /// <summary>
        /// No cache type set
        /// </summary>
        Null = 0,
        
        Memory,

        NCacheExpress,

        AppFabric,

        MemcacheD,

        AzureTableStorage,

        Disk
    }
}
