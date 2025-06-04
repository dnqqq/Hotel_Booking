using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Hotel.Classes;
using WinForms_Hotel.Interfaces;

namespace WinForms_Hotel.Repositories
{
    public class BookingRepository<T> : GenericRepository<T> where T : Booking
    {
        public BookingRepository(IDataStorage<T> storage) : base(storage)
        {
        }

        public void Update(T entity, IDataStorage<T> _storage)
        {
            var existingBooking = _storage.GetById(entity.Id);
            if (existingBooking != null)
            {
                _storage.Update(entity);
                _storage.Save();
            }
        }
    }
}

