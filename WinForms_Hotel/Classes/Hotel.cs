﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Hotel.Classes
{
    public abstract class Hotel : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }

        public abstract void ShowHotelRooms();

        public virtual void ShowHotelInfo()
        {
            Console.WriteLine($"Готель: {Name}, Локація: {Location}, Опис: {Description}");
        }


        public Hotel(string name, string location, string description, int id, int stars) : base(id)
        {
            Name = name;
            Location = location;
            Description = description;
            Stars = stars;
        }
    }
}
