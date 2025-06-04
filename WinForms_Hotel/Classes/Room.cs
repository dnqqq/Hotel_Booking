using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WinForms_Hotel.Classes
{
    public class Room : BaseEntity
    {
        [Required(ErrorMessage = "Name of Hotel is required")]
        [StringLength(30, ErrorMessage = "Name of Hotel must be under 30 characters")]
        public string HotelName { get; set; }
        [Required(ErrorMessage = "Type of room is required")]
        [StringLength(30, MinimumLength = 3,ErrorMessage = "Type of room must be between 3 and 30 characters")]
        public string TypeOfRoom { get; set; }
        [Required(ErrorMessage = "MaxGuests is required")]
        [Range(1,20, ErrorMessage = "MaxGuests must be between 1 and 20")]
        public int MaxGuests { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(1, 1000000, ErrorMessage = "Price must be between 1 and 1000000")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Availability is required")]
        public bool Availability { get; set; }

        public virtual void ShowRoomInfo()
        {
            Console.WriteLine($"Тип номера: {TypeOfRoom}, Кількість гостей: {MaxGuests}, ціна: {Price}, доступність: {Availability}");
        }

        public Room()
        {

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
