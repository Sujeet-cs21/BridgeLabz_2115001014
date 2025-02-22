using NUnit.Framework;
using PP_22_02_25_NUnit;

namespace UnitTest
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        private TemperatureConverter _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new TemperatureConverter();
        }

        [Test]
        public void CelsiusToFahrenheit_ValidCelsius_ReturnsCorrectFahrenheit()
        {
            // Convert 0°C to Fahrenheit (should be 32°F)
            double result = _converter.CelsiusToFahrenheit(0);

            Assert.That(result, Is.EqualTo(32));
        }

        [Test]
        public void CelsiusToFahrenheit_NegativeCelsius_ReturnsCorrectFahrenheit()
        {
            // Convert -40°C to Fahrenheit (should be -40°F)
            double result = _converter.CelsiusToFahrenheit(-40);

            Assert.That(result, Is.EqualTo(-40));
        }

        [Test]
        public void FahrenheitToCelsius_ValidFahrenheit_ReturnsCorrectCelsius()
        {
            // Convert 32°F to Celsius (should be 0°C)
            double result = _converter.FahrenheitToCelsius(32);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void FahrenheitToCelsius_NegativeFahrenheit_ReturnsCorrectCelsius()
        {
            // Convert -40°F to Celsius (should be -40°C)
            double result = _converter.FahrenheitToCelsius(-40);

            Assert.That(result, Is.EqualTo(-40));
        }

        [Test]
        public void CelsiusToFahrenheit_FahrenheitConversionConsistency()
        {
            // Check for consistency in conversion
            double celsius = 100;
            double fahrenheit = _converter.CelsiusToFahrenheit(celsius);
            double convertedBack = _converter.FahrenheitToCelsius(fahrenheit);

            Assert.That(convertedBack, Is.EqualTo(celsius));
        }
    }
}
