using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WinForms_Hotel.Classes
{
    public class Hotel : BaseEntity
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name must be under 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(30, MinimumLength = 3,ErrorMessage = "Location must be between 2 and 30 characters")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 500 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Stars are required")]
        [Range(1, 5, ErrorMessage = "Stars must be between 1 and 5")]
        public int Stars { get; set; }

        public virtual void ShowHotelInfo()
        {
            Console.WriteLine($"Готель: {Name}, Локація: {Location}, Опис: {Description}");
        }

        public Hotel()
        {

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
