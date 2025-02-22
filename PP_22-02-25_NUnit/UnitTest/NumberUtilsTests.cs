using NUnit.Framework;
using PP_22_02_25_NUnit;

namespace UnitTest
{
    [TestFixture]
    public class NumberUtilsTests
    {
        private NumberUtils _numberUtils;

        [SetUp]
        public void Setup()
        {
            _numberUtils = new NumberUtils();
        }

        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void IsEven_ValidNumbers_ReturnsExpectedResult(int number, bool expectedResult)
        {
            Assert.That(_numberUtils.IsEven(number), Is.EqualTo(expectedResult));
        }
    }
}
