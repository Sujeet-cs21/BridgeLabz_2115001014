using NUnit.Framework;
using PP_22_02_25_NUnit;
using System;

namespace UnitTest
{
    [TestFixture]
    public class CalculatorTests1
    {
        private Calculator1 _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator1();
        }

        [Test]
        public void Divide_ByZero_ThrowsArithmeticException()
        {
            Assert.That(() => _calculator.Divide(10, 0), Throws.TypeOf<ArithmeticException>());
        }
    }
}
