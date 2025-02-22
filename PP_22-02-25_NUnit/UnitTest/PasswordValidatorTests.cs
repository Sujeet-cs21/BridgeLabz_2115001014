using NUnit.Framework;
using PP_22_02_25_NUnit;
using System;

namespace UnitTest
{
    [TestFixture]
    public class PasswordValidatorTests
    {
        private PasswordValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new PasswordValidator();
        }

        [Test]
        public void Validate_ValidPassword_ReturnsTrue()
        {
            // Test a valid password
            bool isValid = _validator.Validate("Password123");

            Assert.That(isValid, Is.True);
        }

        [Test]
        public void Validate_PasswordTooShort_ReturnsFalse()
        {
            // Test a password that is too short
            bool isValid = _validator.Validate("Short1");

            Assert.That(isValid, Is.False);
        }

        [Test]
        public void Validate_PasswordWithoutUppercase_ReturnsFalse()
        {
            // Test a password without an uppercase letter
            bool isValid = _validator.Validate("password123");

            Assert.That(isValid, Is.False);
        }

        [Test]
        public void Validate_PasswordWithoutDigit_ReturnsFalse()
        {
            // Test a password without a digit
            bool isValid = _validator.Validate("PasswordNoDigit");

            Assert.That(isValid, Is.False);
        }

        [Test]
        public void Validate_PasswordNullOrEmpty_ThrowsArgumentException()
        {
            // Test for empty or null password
            Assert.Throws<ArgumentException>(() => _validator.Validate(null));
            Assert.Throws<ArgumentException>(() => _validator.Validate(""));
        }
    }
}
