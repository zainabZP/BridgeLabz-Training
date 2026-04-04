using NUnit.Framework;
using NumberUtilsApp;

namespace NumberUtilsNUnitTests
{
    [TestFixture]
    public class NumberUtilsTests
    {
        private NumberUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new NumberUtils();
        }

        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(6, true)]
        [TestCase(7, false)]
        [TestCase(9, false)]
        public void TestIsEven(int number, bool expected)
        {
            bool result = utils.IsEven(number);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
