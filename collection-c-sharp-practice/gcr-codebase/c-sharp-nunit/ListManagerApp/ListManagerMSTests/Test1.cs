using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ListManagerApp;  // important: namespace of ListManager class

namespace ListManagerMSTests
{
    [TestClass]
    public class ListManagerTests
    {
        [TestMethod]
        public void TestAddElement()
        {
            var manager = new ListManager();
            var list = new List<int>();
            manager.AddElement(list, 5);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(5, list[0]);
        }

        [TestMethod]
        public void TestRemoveElement()
        {
            var manager = new ListManager();
            var list = new List<int> { 10 };
            manager.RemoveElement(list, 10);
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void TestGetSize()
        {
            var manager = new ListManager();
            var list = new List<int> { 1, 2, 3 };
            int size = manager.GetSize(list);
            Assert.AreEqual(3, size);
        }
    }
}
