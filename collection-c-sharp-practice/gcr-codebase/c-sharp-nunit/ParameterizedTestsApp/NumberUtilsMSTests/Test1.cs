using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberUtilsApp;

namespace NumberUtilsMSTests
{
    [TestClass]
    public class NumberUtilsTests
    {
        private NumberUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new NumberUtils();
        }

        [DataTestMethod]
        [DataRow(2, true)]
        [DataRow(4, true)]
        [DataRow(6, true)]
        [DataRow(7, false)]
        [DataRow(9, false)]
        public void TestIsEven(int number, bool expected)
        {
            bool result = utils.IsEven(number);
            Assert.AreEqual(expected, result);
        }
    }
}
