using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using Sixeyed.Core.Caching.Caches.TableStorage;
using Sixeyed.Core.Configuration;

namespace Sixeyed.Core.Caching.Caches
{
    public class AzureTableStorage : CacheBase
    {
        private bool _initialised;

        public override CacheType CacheType
        {
            get { return CacheType.AzureTableStorage; }
        }

        public override void Initialise()
        {
            if (!_initialised)
            {
                var table = GetTable();
                table.CreateIfNotExists();
                _initialised = true;
            }
        }

        protected override void SetInternal(string key, object value)
        {
            SetInternal(key, value, null);
        }

        protected override void SetInternal(string key, object value, DateTime expiresAt)
        {
            SetInternal(key, value, expiresAt);
        }

        private void SetInternal(string key, object value, DateTime? expiresAt)
        {
            var entity = new CachedEntity(key);
            entity.Item = value;
            entity.ExpiresAt = expiresAt;
            var table = GetTable();
            //use insert-or-replace to ignore concurrent updates:                
            var insertOrReplaceOperation = TableOperation.InsertOrReplace(entity);
            table.Execute(insertOrReplaceOperation);
        }

        protected override void SetInternal(string key, object value, TimeSpan validFor)
        {
            SetInternal(key, value, DateTime.UtcNow.Add(validFor));
        }

        protected override object GetInternal(string key)
        {
            var table = GetTable();
            var retrieveOperation = TableOperation.Retrieve<CachedEntity>(CachedEntity.DefaultPartitionKey, key);
            var entity = table.Execute(retrieveOperation).Result as CachedEntity;
            if (entity.ExpiresAt.HasValue && entity.ExpiresAt > DateTime.UtcNow)
            {
                entity = null;
            }
            return entity;
        }

        //TODO: 
        protected override void RemoveInternal(string key)
        {
            throw new NotImplementedException();
        }

        protected override bool ExistsInternal(string key)
        {
            throw new NotImplementedException();
        }

        private static CloudStorageAccount GetStorageAccount()
        {
            var cacheName = CacheConfiguration.Current.DefaultCacheName;
            return CloudStorageAccount.Parse(ConfigurationManager.ConnectionStrings[cacheName].ConnectionString);
        }

        private static CloudTable GetTable()
        {
            var account = GetStorageAccount();
            var tableClient = account.CreateCloudTableClient();
            return tableClient.GetTableReference(typeof(CachedEntity).Name);
        }         
    }
}
