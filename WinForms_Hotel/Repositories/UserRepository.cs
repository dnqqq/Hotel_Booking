using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Hotel.Classes;
using WinForms_Hotel.Interfaces;

namespace WinForms_Hotel.Repositories
{
    public class UserRepository<T> : GenericRepository<T> where T : User
    {
        public UserRepository(IDataStorage<T> storage) : base(storage)
        {
        }

        public T GetByName(string name, IDataStorage<T> _storage)
        {
            return _storage.GetAll().FirstOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<T> GetAllSortedByName(IDataStorage<T> _storage)
        {
            return _storage.GetAll().OrderBy(u => u.Name).ToList();
        }

        public void Update(T entity, IDataStorage<T> _storage)
        {
            var existingUser = _storage.GetById(entity.Id);
            if (existingUser != null)
            {
                _storage.Update(entity);
                _storage.Save();  
            }
        }
    }
}
