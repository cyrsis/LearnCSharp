using System;

namespace Cubo.Core.Domain
{
    public class Item : Entity
    {
        public Guid BucketId { get; protected set; }
        public string Key { get; protected set; }
        public string Value { get; protected set; }

        protected Item()
        {
        }

        public Item(Guid bucketId, string key, string value)
        {
            if(string.IsNullOrWhiteSpace(key))
            {
                throw new CuboException("empty_item_key", 
                    "Item can not have an empty key.");
            }
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new CuboException("empty_item_value", 
                    "Item can not have an empty value.");
            }
            BucketId = bucketId;
            Key = key.ToLowerInvariant();
            Value = value;
        }
    }
}