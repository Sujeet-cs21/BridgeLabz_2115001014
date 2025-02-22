using NUnit.Framework;
using PP_22_02_25_NUnit;

[TestFixture]
public class NumberUtilsTests1
{
    private NumberUtils1 _numberUtils;

    [SetUp]
    public void Setup()
    {
        _numberUtils = new NumberUtils1();
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

    [Test, Timeout(2000)]
    public void LongRunningTask_ShouldFailIfExceedsTimeout()
    {
        _numberUtils.LongRunningTask();
    }
}
