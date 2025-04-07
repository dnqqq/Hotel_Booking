using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Hotel.Classes;

namespace WinForms_Hotel.Repositories
{
    public class HotelRepository<T> : GenericRepository<T> where T : Hotel
    {
        public T GetByName(string name)
        {
            return _entities.FirstOrDefault(h => h.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<T> GetAllSortedByName()
        {
            return _entities.OrderBy(h => h.Name).ToList();
        }

        public void Update(T entity)
        {
            var index = _entities.FindIndex(e => e.Id == entity.Id);
            if (index >= 0)
            {
                _entities[index] = entity;
            }
        }

    }
}
