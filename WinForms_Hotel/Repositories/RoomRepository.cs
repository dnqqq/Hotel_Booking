using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Hotel.Classes;
using WinForms_Hotel.Interfaces;

namespace WinForms_Hotel.Repositories
{
    public class RoomRepository<T> : GenericRepository<T> where T : Room
    {
        public RoomRepository(IDataStorage<T> storage) : base(storage)
        {
        }

        public void Update(T entity, IDataStorage<T> _storage)
        {
            var existingRoom = _storage.GetById(entity.Id);
            if (existingRoom != null)
            {
                _storage.Update(entity);
                _storage.Save();
            }
        }
    }
}
