using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Hotel.Repositories;

namespace WinForms_Hotel.Classes
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ObjectId { get; set; }

        [BsonElement("Id")] // Явно вказуємо, що це поле мапиться на "Id" в MongoDB
        public int Id { get; set; }

        protected BaseEntity(int id)
        {
            Id = id;
        }

        protected BaseEntity() { }
    }
}
