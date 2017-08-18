using Sixeyed.Core.Configuration;
using Sixeyed.Core.Cryptography;
using Sixeyed.Core.Logging;
using System;
using System.IO;
using System.Linq;

namespace Sixeyed.Core.Caching.Caches
{
    public class DiskCache : CacheBase
    {
        private string _directory;
        private bool _directoryValid = true;

        public override CacheType CacheType
        {
            get { return CacheType.Disk; }
        }

        protected override void InitialiseInternal()
        {
            _directory = CacheConfiguration.Current.DiskCache.Path;
            Log.Debug("DiskCache.Initialise - initialising with path: {0}", _directory);
            try
            {
                if (!Directory.Exists(_directory))
                {
                    _directoryValid = false;
                    Log.Error("DiskCache - directory specified in diskCache.path config: {0} does not exist. Not caching.", _directory);
                }
                else if (HasExceededQuota())
                {
                    Log.Warn("DiskCache - exceeded quota for directory specified in diskCache.path config: {0}. Not caching.", _directory);
                }
            }
            catch (Exception ex)
            {
                _directoryValid = false;
                Log.Error("DiskCache - error checking diskCache.path config: {0}, message: {1}. Not caching.", _directory, ex);
            }
        }

        protected override void SetInternal(string key, object value)
        {
            SetInternal(key, value, null);
        }

        protected override void SetInternal(string key, object value, TimeSpan validFor)
        {
            SetInternal(key, value, DateTime.UtcNow.Add(validFor));
        }

        protected override void SetInternal(string key, object value, DateTime expiresAt)
        {
            SetInternal(key, value, expiresAt);
        }

        private void SetInternal(string key, object value, DateTime? expiresAt)
        {
            try
            {
                if (_directoryValid && !HasExceededQuota())
                {
                    //check for a non-expiring cache:
                    var cachePath = GetFilePath(key);
                    if (File.Exists(cachePath))
                    {
                        File.Delete(cachePath);
                    }
                    //check for other caches:
                    var fileName = GetFileNameSearchPattern(key);
                    var existingCaches = Directory.EnumerateFiles(_directory, fileName);
                    foreach (var existingCache in existingCaches)
                    {
                        File.Delete(Path.Combine(_directory, existingCache));
                    }
                    var newCachePath = GetFilePath(key, expiresAt);
                    var item = value as string;
                    if (item != null)
                    {
                        if (CacheConfiguration.Current.DiskCache.EncryptItems)
                        {
                            var encryptedBytes = SimpleAes.Encrypt(item);
                            File.WriteAllBytes(newCachePath, encryptedBytes);
                        }
                        else
                        {
                            File.WriteAllText(newCachePath, item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Warn("DiskCache.SetInternal - failed, item not cached. Message: {0}", ex.Message);
            }
        }

        protected override object GetInternal(string key)
        {
            object value = null;
            try
            {
                if (_directoryValid)
                {
                    //check for a non-expiring cache:
                    var cachePath = GetFilePath(key);
                    if (!File.Exists(cachePath))
                    {
                        cachePath = null;
                        //check for expired caches:
                        var fileName = GetFileNameSearchPattern(key);
                        var existingCaches = Directory.EnumerateFiles(_directory, fileName).OrderByDescending(x => x);
                        if (existingCaches.Count() > 0)
                        {
                            var mostRecentCache = existingCaches.ElementAt(0);
                            //if the most recent cache is live, return it -
                            //format is {guid}.cache.{expiresAt}.expiry
                            if (mostRecentCache.EndsWith(".expiry"))
                            {
                                var expiresAt = mostRecentCache.Substring(mostRecentCache.IndexOf(".expiry") - 19, 19);
                                var expiresAtDate = expiresAt.Replace('-', '/').Replace('_', ':');
                                var expiryDate = DateTime.Parse(expiresAtDate);
                                if (expiryDate > DateTime.UtcNow)
                                {
                                    cachePath = Path.Combine(_directory, mostRecentCache);
                                }
                            }
                        }
                    }
                    if (cachePath != null)
                    {
                        if (CacheConfiguration.Current.DiskCache.EncryptItems)
                        {
                            var encryptedBytes = File.ReadAllBytes(cachePath);
                            value = SimpleAes.Decrypt(encryptedBytes);
                        }
                        else
                        {
                            value = File.ReadAllText(cachePath);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Warn("DiskCache.GetInternal - failed, item not returned. Message: {0}", ex.Message);
            }
            return value;
        }

        protected override void RemoveInternal(string key)
        {
            try
            {
                if (_directoryValid)
                {
                    var path = GetFilePath(key);
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
            }
            catch (Exception ex)
            {
                //do nothing
            }
        }

        protected override bool ExistsInternal(string key)
        {
            var exists = false;
            try
            {
                if (_directoryValid)
                {
                    var path = GetFilePath(key);
                    exists = File.Exists(path);
                }
            }
            catch (Exception ex)
            {
                //do nothing
            }
            return exists;
        }

        private static string GetFileName(string cacheKey)
        {
            return cacheKey + ".cache";
        }

        private string GetFileNameSearchPattern(string cacheKey)
        {
            return GetFileName(cacheKey) + ".*";
        }

        private string GetFilePath(string cacheKey)
        {
            return Path.Combine(_directory, GetFileName(cacheKey));
        }

        private string GetFilePath(string cacheKey, DateTime? expiresAt)
        {
            var path = GetFilePath(cacheKey);
            if (expiresAt.HasValue)
            {
                path = string.Format("{0}.{1}.expiry", path, expiresAt.Value.ToString("yyyy-MM-ddTHH_mm_ss"));
            }
            return path;
        }

        private bool HasExceededQuota()
        {
            var size = new DirectoryInfo(_directory).GetFiles().Sum(x => x.Length);
            return (size / (1024 * 1024)) > CacheConfiguration.Current.DiskCache.MaxSizeInMb;
        }
    }
}
