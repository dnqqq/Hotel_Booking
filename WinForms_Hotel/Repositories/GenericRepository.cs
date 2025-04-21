using System;
using System.Collections.Generic;
using System.Linq;
using WinForms_Hotel.Classes;
using WinForms_Hotel.Interfaces;

namespace WinForms_Hotel.Repositories
{
    public class GenericRepository<T> where T : BaseEntity
    {
        private readonly IDataStorage<T> _storage;

        public List<T> GetAll()
        {
            return _storage.GetAll();
        }

        public T? GetById(int id)
        {
            return _storage.GetById(id);
        }

        public void Add(T entity)
        {
            _storage.Add(entity);
            _storage.Save();  
        }

        public void Update(T entity)
        {
            _storage.Update(entity);
            _storage.Save();  
        }

        public void Remove(int id)
        {
            _storage.Delete(id);
            _storage.Save();  
        }

        public GenericRepository(IDataStorage<T> storage)
        {
            _storage = storage;
        }
    }
    
}
