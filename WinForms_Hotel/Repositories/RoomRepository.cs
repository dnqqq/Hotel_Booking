using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Hotel.Classes;

namespace WinForms_Hotel.Repositories
{
    public class RoomRepository<T> : GenericRepository<T> where T : Room
    {
        //public Room GetByTypeOfRoom(string name)
        //{
        //    return _entities.FirstOrDefault(r => r.TypeOfRoom.Equals(name, StringComparison.OrdinalIgnoreCase));
        //}

        //public List<Room> GetAllSortedByPrice()
        //{
        //    return _entities.OrderBy(r => r.Price).ToList();
        //}

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
