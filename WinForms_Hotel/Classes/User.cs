using System;
using BCrypt.Net;
using WinForms_Hotel.Interfaces;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace WinForms_Hotel.Classes
{
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 30 characters")]
        [BsonElement("Name")] // Явне маппінг для MongoDB
        public string Name { get; set; }

        [BsonElement("PasswordHash")]
        public string PasswordHash { get; set; }

        [BsonElement("Salt")]
        public string Salt { get; set; }

        [BsonElement("Admin")]
        public bool Admin { get; set; }

        public User() : base(0) { }

        [JsonConstructor]
        public User(string name, string passwordHash, string salt, int id, bool admin = false) : base(id)
        {
            Name = name;
            PasswordHash = passwordHash;
            Salt = salt;
            Admin = admin;
        }

        public bool VerifyPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password + Salt, PasswordHash);
        }
    }
}
