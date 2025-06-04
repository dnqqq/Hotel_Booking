using WinForms_Hotel.Classes;

namespace UnitTests
{
    [TestClass]
    public class ValidationServiceTests
    {
        [TestMethod]
        public void Validate_ValidUser_ReturnsNoErrors()
        {
            // Arrange
            var user = new User("testuser", "hash", "salt", 1);

            // Act
            var results = ValidationService.Validate(user);

            // Assert
            Assert.AreEqual(0, results.Count);
        }

        [TestMethod]
        public void Validate_InvalidUser_ReturnsErrors()
        {
            // Arrange
            var user = new User("", "", "", 0); // Невалідні дані

            // Act
            var results = ValidationService.Validate(user);

            // Assert
            Assert.IsTrue(results.Count > 0);
        }

        [TestMethod]
        public void IsValid_ValidHotel_ReturnsTrue()
        {
            // Arrange
            var hotel = new Hotel { Name = "Valid Hotel", Location = "City", Description = "Good Hotel", Stars = 5, Id = 1 };

            // Act & Assert
            Assert.IsTrue(ValidationService.IsValid(hotel));
        }
    }
}
