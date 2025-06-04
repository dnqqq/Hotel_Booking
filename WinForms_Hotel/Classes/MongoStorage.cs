using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using WinForms_Hotel.Classes;
using WinForms_Hotel.Interfaces;

namespace WinForms_Hotel.Repositories
{
    public class MongoStorage<T> : IDataStorage<T> where T : BaseEntity, new()
    {
        private readonly IMongoCollection<T> _collection;

        public MongoStorage(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _collection = database.GetCollection<T>(collectionName);

            // Реєструємо маппінг класу
            RegisterClassMapIfNeeded();
        }

        private void RegisterClassMapIfNeeded()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(T)))
            {
                BsonClassMap.RegisterClassMap<T>(cm =>
                {
                    cm.AutoMap();
                    cm.SetIgnoreExtraElements(true); // Ігноруємо зайві поля в базі
                });
            }
        }

        public void Add(T entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = GetNextNumericId();
            }
            _collection.InsertOne(entity);
        }

        private int GetNextNumericId()
        {
            var lastEntity = _collection.Find(FilterDefinition<T>.Empty)
                .SortByDescending(x => x.Id)
                .Limit(1)
                .FirstOrDefault();

            return lastEntity?.Id + 1 ?? 1;
        }

        public void Update(T entity) => _collection.ReplaceOne(x => x.Id == entity.Id, entity);
        public void Delete(int id) => _collection.DeleteOne(x => x.Id == id);
        public T? GetById(int id) => _collection.Find(x => x.Id == id).FirstOrDefault();
        public List<T> GetAll() => _collection.Find(_ => true).ToList();
        public void Save() { }
    }
}