using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorMsTests
{
    [TestClass]
    public class Test1
    {
        private Calculator.Calculator calc = null!;

        [TestInitialize]
        public void Setup()
        {
            calc = new Calculator.Calculator();
        }

        [TestMethod]
        public void Add_Test()
        {
            int result = calc.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_Test()
        {
            int result = calc.Subtract(5, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Multiply_Test()
        {
            int result = calc.Multiply(4, 3);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Divide_Test()
        {
            int result = calc.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_By_Zero_Test()
        {
            try
            {
                calc.Divide(10, 0);
                Assert.Fail("Exception was not thrown");
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
