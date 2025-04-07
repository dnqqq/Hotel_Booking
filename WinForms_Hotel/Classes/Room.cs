using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Hotel.Classes
{
    public class Room : BaseEntity
    {
        public string HotelName { get; set; }
        public string TypeOfRoom { get; set; }
        public int MaxGuests { get; set; }
        public float Price { get; set; }
        public bool Availability { get; set; }

        public virtual void ShowRoomInfo()
        {
            Console.WriteLine($"Тип номера: {TypeOfRoom}, Кількість гостей: {MaxGuests}, ціна: {Price}, доступність: {Availability}");
        }


        public Room(string hotelName, string typeOfRoom, int maxGuests, float price, bool availability, int id) : base(id)
        {
            HotelName = hotelName;
            TypeOfRoom = typeOfRoom;
            MaxGuests = maxGuests;
            Price = price;
            Availability = availability;
        }
    }
}
