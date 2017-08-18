using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository.Interface
{
    public interface IRepository<T, TKey>
    {
        IEnumerable<T> GetItems();

        T GetItem(TKey key);

        void AddItem(T newItem);

        void UpdateItem(TKey key, T updatedItem);

        void DeleteItem(TKey key);

        void UpdateItems(IEnumerable<T> updatedItems);
    }
}
