using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatabaseConnectionApp;  // must match your main project namespace

namespace DatabaseConnectionMSTests
{
    [TestClass]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection db;

        [TestInitialize]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        [TestCleanup]
        public void Cleanup()
        {
            db.Disconnect();
        }

        [TestMethod]
        public void TestConnectionIsEstablished()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [TestMethod]
        public void TestConnectionIsClosedAfterCleanup()
        {
            Assert.IsTrue(db.IsConnected); // MSTest runs Cleanup after this
        }
    }
}
