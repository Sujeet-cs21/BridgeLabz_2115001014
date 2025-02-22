using NUnit.Framework;
using PP_22_02_25_NUnit;
using System;

namespace UnitTest
{
    [TestFixture]
    public class UserRegistrationTests
    {
        private UserRegistration _userRegistration;

        [SetUp]
        public void Setup()
        {
            _userRegistration = new UserRegistration();
        }

        [Test]
        public void RegisterUser_ValidInputs_Succeeds()
        {
            // Test valid registration details
            Assert.DoesNotThrow(() => _userRegistration.RegisterUser("User", "user@example.com", "Password123"));
        }

        [Test]
        public void RegisterUser_EmptyUsername_ThrowsArgumentException()
        {
            // Test empty username
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("", "user@example.com", "Password123"));
        }

        [Test]
        public void RegisterUser_InvalidEmail_ThrowsArgumentException()
        {
            // Test invalid email format
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("User", "invalid-email", "Password123"));
        }

        [Test]
        public void RegisterUser_EmptyEmail_ThrowsArgumentException()
        {
            // Test empty email
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("User", "", "Password123"));
        }

        [Test]
        public void RegisterUser_TooShortPassword_ThrowsArgumentException()
        {
            // Test password shorter than 8 characters
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("User", "user@example.com", "Short1"));
        }

        [Test]
        public void RegisterUser_EmptyPassword_ThrowsArgumentException()
        {
            // Test empty password
            Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("User", "user@example.com", ""));
        }
    }
}
