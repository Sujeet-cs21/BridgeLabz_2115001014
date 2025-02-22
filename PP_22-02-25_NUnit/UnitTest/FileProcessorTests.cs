using NUnit.Framework;
using PP_22_02_25_NUnit;
using System.IO;

namespace UnitTest
{
    [TestFixture]
    public class FileProcessorTests
    {
        private FileProcessor _fileProcessor;
        private string _testFileName = "testfile.txt";

        [SetUp]
        public void Setup()
        {
            _fileProcessor = new FileProcessor();
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
            if (File.Exists(_testFileName))
            {
                File.Delete(_testFileName);
            }
        }

        [Test]
        public void WriteToFile_ValidContent_FileIsWrittenSuccessfully()
        {
            string content = "Hello, world!";

            _fileProcessor.WriteToFile(_testFileName, content);

            // Assert that the file exists
            Assert.That(File.Exists(_testFileName), Is.True);

            // Assert that the content is correct
            string readContent = _fileProcessor.ReadFromFile(_testFileName);
            Assert.That(readContent, Is.EqualTo(content));
        }

        [Test]
        public void ReadFromFile_FileDoesNotExist_ThrowsIOException()
        {
            Assert.Throws<IOException>(() => _fileProcessor.ReadFromFile("nonexistentfile.txt"));
        }

        [Test]
        public void WriteToFile_EmptyContent_FileIsWrittenSuccessfully()
        {
            string content = "";

            _fileProcessor.WriteToFile(_testFileName, content);

            // Assert that the file exists
            Assert.That(File.Exists(_testFileName), Is.True);

            // Assert that the content is correct (empty string)
            string readContent = _fileProcessor.ReadFromFile(_testFileName);
            Assert.That(readContent, Is.EqualTo(content));
        }
    }
}
