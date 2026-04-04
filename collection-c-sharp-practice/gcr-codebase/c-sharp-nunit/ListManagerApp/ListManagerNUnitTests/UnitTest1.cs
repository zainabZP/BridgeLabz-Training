using NUnit.Framework;
using System.Collections.Generic;
using ListManagerApp;  // reference to your main project

namespace ListManagerNUnitTests
{
    [TestFixture]
    public class ListManagerTests
    {
        [Test]
        public void TestAddElement()
        {
            var manager = new ListManager();
            var list = new List<int>();
            manager.AddElement(list, 5);

            // NUnit style assertions
            Assert.That(list.Count, Is.EqualTo(1));
            Assert.That(list[0], Is.EqualTo(5));
        }

        [Test]
        public void TestRemoveElement()
        {
            var manager = new ListManager();
            var list = new List<int> { 10 };
            manager.RemoveElement(list, 10);

            Assert.That(list.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestGetSize()
        {
            var manager = new ListManager();
            var list = new List<int> { 1, 2, 3 };
            int size = manager.GetSize(list);

            Assert.That(size, Is.EqualTo(3));
        }
    }
}
