using StorageApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorageApp.Repositories
{
    public class ListRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _items = new List<T>();

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Add(T item)
        {
            item.Id = _items.Any() ? _items.Max(item => item.Id) + 1 : 1;
            _items.Add(item);
        }

        public void Save()
        {
            //Data already saved.
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
