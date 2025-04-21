using System;
using BCrypt.Net;
using WinForms_Hotel.Interfaces;
using System.Text.Json.Serialization;

namespace WinForms_Hotel.Classes
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public bool Admin { get; set; }

        // Пустий конструктор для десеріалізації
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
