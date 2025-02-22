using System;
using NUnit.Framework;
using PP_22_02_25_NUnit;

namespace UnitTest
{
    public class CalculatorTest
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void AdditionTest()
        {
            int expected = 5;
            int actual = _calculator.Add(2, 3);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SubtractionTest()
        {
            int expected = 1;
            int actual = _calculator.Subtract(4, 3);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MultiplicationTest()
        {
            int expected = 12;
            int actual = _calculator.Multiply(4, 3);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DivisionTest()
        {
            int expected = 2;
            int actual = _calculator.Divide(6, 3);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
        }
    }
}
