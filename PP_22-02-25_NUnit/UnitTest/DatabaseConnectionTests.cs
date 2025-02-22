using NUnit.Framework;
using PP_22_02_25_NUnit;

namespace UnitTest
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection _dbConnection;

        [SetUp]
        public void Setup()
        {
            _dbConnection = new DatabaseConnection();
            _dbConnection.Connect();
        }

        [TearDown]
        public void Teardown()
        {
            _dbConnection.Disconnect();
        }

        [Test]
        public void Connect_EstablishesConnection()
        {
            Assert.That(_dbConnection.IsConnected, Is.True);
        }

        [Test]
        public void Disconnect_ClosesConnection()
        {
            _dbConnection.Disconnect();
            Assert.That(_dbConnection.IsConnected, Is.False);
        }
    }
}
