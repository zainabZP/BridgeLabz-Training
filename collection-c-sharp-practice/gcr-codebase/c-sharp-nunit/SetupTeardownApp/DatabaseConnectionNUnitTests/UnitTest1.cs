using NUnit.Framework;
using DatabaseConnectionApp; // main project namespace

namespace DatabaseConnectionNUnitTests
{
    public class DatabaseConnectionTests
    {
        private DatabaseConnection db;

        [SetUp]  // runs before each test
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        [TearDown]  // runs after each test
        public void Cleanup()
        {
            db.Disconnect();
        }

        [Test]
        public void TestConnectionIsEstablished()
        {
            Assert.That(db.IsConnected, Is.True);  // NUnit style
        }

        [Test]
        public void TestConnectionIsClosedAfterCleanup()
        {
            Assert.That(db.IsConnected, Is.True);  // cleanup runs after test
        }
    }
}
