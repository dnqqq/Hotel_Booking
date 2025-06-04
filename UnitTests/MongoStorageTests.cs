using WinForms_Hotel.Classes;
using WinForms_Hotel.Repositories;

namespace UnitTests
{
    [TestClass]
    public class MongoStorageTests
    {
        private MongoStorage<Hotel> _storage;
        private const string TestDbName = "HotelDB_Test";

        [TestInitialize]
        public void Setup()
        {
            _storage = new MongoStorage<Hotel>("mongodb://localhost:27017", TestDbName, "Hotels");
            var hotels = _storage.GetAll();
            foreach (var hotel in hotels)
            {
                _storage.Delete(hotel.Id);
            }
        }

        [TestMethod]
        public void Add_NewHotel_ShouldStoreInDatabase()
        {
            // Arrange
            var hotel = new Hotel { Name = "Test Hotel"};

            // Act
            _storage.Add(hotel);
            var result = _storage.GetById(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Test Hotel", result.Name);
        }

        [TestMethod]
        public void GetById_NonExistingId_ShouldReturnNull()
        {
            // Act
            var result = _storage.GetById(999);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Update_ExistingHotel_ShouldUpdateData()
        {
            // Arrange
            var hotel = new Hotel { Name = "Old Hotel", Location = "City", Description = "Good Hotel", Stars = 5, Id = 2 };
            _storage.Add(hotel);
            hotel.Name = "New Name";

            // Act
            _storage.Update(hotel);
            var updated = _storage.GetById(2);

            // Assert
            Assert.AreEqual("New Name", updated.Name);
        }
    }
}
