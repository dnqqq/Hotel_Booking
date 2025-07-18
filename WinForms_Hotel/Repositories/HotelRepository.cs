﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Hotel.Classes;
using WinForms_Hotel.Interfaces;

namespace WinForms_Hotel.Repositories
{
    public class HotelRepository<T> : GenericRepository<T> where T : Hotel
    {
        public HotelRepository(IDataStorage<T> storage) : base(storage)
        {
        }

        public T GetByName(string name, IDataStorage<T> _storage)
        {
            return _storage.GetAll().FirstOrDefault(h => h.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<T> GetAllSortedByName(IDataStorage<T> _storage)
        {
            return _storage.GetAll().OrderBy(h => h.Name).ToList();
        }

        public void Update(T entity, IDataStorage<T> _storage)
        {
            var existingHotel = _storage.GetById(entity.Id);
            if (existingHotel != null)
            {
                _storage.Update(entity);
                _storage.Save();
            }
        }

    }
}
