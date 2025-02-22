using PP_22_02_25_NUnit;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        public void Reverse_String_ReturnsReversedString()
        {
            Assert.That(_stringUtils.Reverse("abc"), Is.EqualTo("cba"));
        }

        [Test]
        public void IsPalindrome_PalindromeString_ReturnsTrue()
        {
            Assert.That(_stringUtils.IsPalindrome("madam"), Is.True);
        }

        [Test]
        public void IsPalindrome_NonPalindromeString_ReturnsFalse()
        {
            Assert.That(_stringUtils.IsPalindrome("hello"), Is.False);
        }

        [Test]
        public void ToUpperCase_String_ReturnsUpperCaseString()
        {
            Assert.That(_stringUtils.ToUpperCase("hello"), Is.EqualTo("HELLO"));
        }
    }
}
