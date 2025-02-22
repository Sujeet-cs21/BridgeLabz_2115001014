using NUnit.Framework;
using PP_22_02_25_NUnit;
using System;

namespace UnitTest
{
    [TestFixture]
    public class DateFormatterTests
    {
        private DateFormatter _dateFormatter;

        [SetUp]
        public void Setup()
        {
            _dateFormatter = new DateFormatter();
        }

        [Test]
        public void FormatDate_ValidDate_ReturnsCorrectFormat()
        {
            // Test valid date conversion
            string result = _dateFormatter.FormatDate("2025-02-22");

            Assert.That(result, Is.EqualTo("22-02-2025"));
        }

        [Test]
        public void FormatDate_ValidLeapYearDate_ReturnsCorrectFormat()
        {
            // Test valid leap year date conversion
            string result = _dateFormatter.FormatDate("2024-02-29");

            Assert.That(result, Is.EqualTo("29-02-2024"));
        }

        [Test]
        public void FormatDate_InvalidDateFormat_ThrowsFormatException()
        {
            // Test invalid date format
            Assert.Throws<FormatException>(() => _dateFormatter.FormatDate("22-02-2025"));
        }

        [Test]
        public void FormatDate_EmptyDate_ThrowsArgumentException()
        {
            // Test empty date
            Assert.Throws<ArgumentException>(() => _dateFormatter.FormatDate(""));
        }

        [Test]
        public void FormatDate_NullDate_ThrowsArgumentException()
        {
            // Test null date
            Assert.Throws<ArgumentException>(() => _dateFormatter.FormatDate(null));
        }
    }
}
