using System;
using System.Collections.Generic;
using System.Linq;

namespace Cubo.Core.Domain
{
    public class Bucket : Entity
    {
        private ISet<Item> _items = new HashSet<Item>();
        public string Name { get; protected set; }
        public IEnumerable<Item> Items
        {
            get => _items;
            protected set => _items = new HashSet<Item>(value);
        }

        public DateTime CreatedAt { get; protected set;}

        protected Bucket()
        {
        }

        public Bucket(Guid id, string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new CuboException("empty_bucket_name", 
                    "Bucket can not have an empty name.");
            }
            Id = id;
            Name = name.ToLowerInvariant();
            CreatedAt = DateTime.UtcNow;
        }

        public Item GetItemOrFail(string key)
        {
            var fixedKey = key.ToLowerInvariant();
            var item = Items.SingleOrDefault(x => x.Key == fixedKey);
            if(item == null)
            {
                throw new CuboException("item_not_found", 
                    $"Item with key '{key}' was not found in bucket '{Name}'.");
            }

            return item;
        }

        public void AddItem(string key, string value)
        {
            var fixedKey = key.ToLowerInvariant();
            if(Items.Any(x => x.Key == fixedKey))
            {
                throw new CuboException("item_already_exists", 
                    $"Item with key '{key}' already exists.");
            }
            _items.Add(new Item(Id, fixedKey, value));
        }

        public void RemoveItem(string key)
        {
            var fixedKey = key.ToLowerInvariant();
            var item = GetItemOrFail(key);
            _items.Remove(item);
        }
    }
}