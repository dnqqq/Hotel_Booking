﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Hotel.Classes;

namespace WinForms_Hotel.Interfaces
{
    public interface IDataStorage<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T? GetById(int id);
        List<T> GetAll();
        void Save();
    }
}
