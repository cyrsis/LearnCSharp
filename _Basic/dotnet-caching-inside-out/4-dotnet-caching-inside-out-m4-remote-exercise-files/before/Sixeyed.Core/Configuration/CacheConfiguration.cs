using System.Configuration;
using Sixeyed.Core.Logging;
using Sixeyed.Core.Caching;
using Sixeyed.Core.Serialization;

namespace Sixeyed.Core.Configuration
{
    /// <summary>
    /// Configuration section for configuring caching
    /// </summary>
    public class CacheConfiguration : ConfigurationSection
    {
        private static bool _loggedWarning;

        /// <summary>
        /// Returns the currently configured settings
        /// </summary>
        public static CacheConfiguration Current
        {
            get
            {
                var current = ConfigurationManager.GetSection("sixeyed.core.caching") as CacheConfiguration;
                if (current == null)
                {
                    current = new CacheConfiguration();
                    if (!_loggedWarning)
                    {
                        Log.Warn("Configuration section: <sixeyed.core.caching> not specified. Default configuration will be used");
                        _loggedWarning = true;
                    }
                }
                return current; 
            }
        }

        /// <summary>
        /// Returns the root path configuration settings
        /// </summary>
        [ConfigurationProperty(SettingName.Enabled, DefaultValue=true)]
        public bool Enabled
        {
            get { return (bool)this[SettingName.Enabled]; }
        }

        /// <summary>
        /// Returns the configuration settins for cache targets
        /// </summary>
        [ConfigurationProperty(SettingName.Targets)]
        public CacheTargetCollection Targets
        {
            get { return (CacheTargetCollection)this[SettingName.Targets]; }
        }
        
        /// <summary>
        /// Returns the root path configuration settings
        /// </summary>
        [ConfigurationProperty(SettingName.HashPrefixInCacheKey, DefaultValue = false)]
        public bool HashPrefixInCacheKey
        {
            get { return (bool)this[SettingName.HashPrefixInCacheKey]; }
        }

        /// <summary>
        /// Returns the configured name of the out-of-process cache
        /// </summary>
        [ConfigurationProperty(SettingName.DefaultCacheName, DefaultValue="Sixeyed.Core.Cache")]
        public string DefaultCacheName
        {
            get { return (string)this[SettingName.DefaultCacheName]; }
        }

        [ConfigurationProperty(SettingName.DefaultCacheType, DefaultValue = CacheType.Memory)]
        public CacheType DefaultCacheType
        {
            get { return (CacheType)this[SettingName.DefaultCacheType]; }
        }

        [ConfigurationProperty(SettingName.DefaultSerializationFormat, DefaultValue = SerializationFormat.Json)]
        public SerializationFormat DefaultSerializationFormat
        {
            get { return (SerializationFormat)this[SettingName.DefaultSerializationFormat]; }
        }

        [ConfigurationProperty(SettingName.DiskCache)]
        public DiskCacheElement DiskCache
        {
            get { return (DiskCacheElement)this[SettingName.DiskCache]; }
        }

        /// <summary>
        /// Constants for indexing settings
        /// </summary>
        private struct SettingName
        {
            /// <summary>
            /// enabled
            /// </summary>
            public const string Enabled = "enabled";

            /// <summary>
            /// targets
            /// </summary>
            public const string Targets = "targets";

            /// <summary>
            /// defaultCacheName
            /// </summary>
            public const string DefaultCacheName = "defaultCacheName";

            /// <summary>
            /// defaultCacheType
            /// </summary>
            public const string DefaultCacheType = "defaultCacheType";

            /// <summary>
            /// defaultSerializationFormat
            /// </summary>
            public const string DefaultSerializationFormat = "defaultSerializationFormat";

            /// <summary>
            /// hashPrefixInCacheKey
            /// </summary>
            public const string HashPrefixInCacheKey = "hashPrefixInCacheKey";

            /// <summary>
            /// diskCache
            /// </summary>
            public const string DiskCache = "diskCache";
        }
    }
}
