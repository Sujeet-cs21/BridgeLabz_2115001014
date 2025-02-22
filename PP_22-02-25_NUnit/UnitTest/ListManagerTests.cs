using NUnit.Framework;
using System.Collections.Generic;
using PP_22_02_25_NUnit;

namespace UnitTest
{
    [TestFixture]
    public class ListManagerTests
    {
        private ListManager _listManager;
        private List<int> _testList;

        [SetUp]
        public void Setup()
        {
            _listManager = new ListManager();
            _testList = new List<int>();
        }

        [Test]
        public void AddElement_AddsElementToList()
        {
            _listManager.AddElement(_testList, 5);
            Assert.That(_testList.Contains(5), Is.True);
        }

        [Test]
        public void RemoveElement_RemovesElementFromList()
        {
            _testList.Add(5);
            _listManager.RemoveElement(_testList, 5);
            Assert.That(_testList.Contains(5), Is.False);
        }

        [Test]
        public void GetSize_ReturnsCorrectSize()
        {
            _listManager.AddElement(_testList, 1);
            _listManager.AddElement(_testList, 2);
            Assert.That(_listManager.GetSize(_testList), Is.EqualTo(2));
        }
    }
}
