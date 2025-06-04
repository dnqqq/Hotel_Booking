using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Hotel.Interfaces;
using System.ComponentModel.DataAnnotations;


namespace WinForms_Hotel.Classes
{
    public class Booking : BaseEntity, IBooking
    {
        [Required(ErrorMessage = "Hotel is required")]
        public Hotel Hotel { get; set; }

        [Required(ErrorMessage = "User is required")]
        public User User { get; set; }

        [Required(ErrorMessage = "Room is required")]
        public Room Room { get; set; }

        [Required(ErrorMessage = "DateIn is required")]
        public string DateIn { get; set; }

        [Required(ErrorMessage = "DateOut is required")]
        public string DateOut { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        // Публічний безпараметричний конструктор для MongoDB
        public Booking() { }

        public Booking(Hotel hotel, User user, Room room, string dateIn, string dateOut, string status, int id) : base(id)
        {
            Hotel = hotel;
            User = user;
            Room = room;
            DateIn = dateIn;
            DateOut = dateOut;
            Status = status;
        }

        public void ConfirmBooking()
        {
            Status = "booked";
            Console.WriteLine("Бронювання виконане");
        }

        public void CancelBooking()
        {
            Status = "canceled";
            Console.WriteLine("Бронювання скасоване");
        }
    }
}
