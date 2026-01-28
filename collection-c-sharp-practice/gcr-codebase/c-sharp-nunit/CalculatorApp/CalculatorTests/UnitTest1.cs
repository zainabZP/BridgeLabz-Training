using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    public class Tests
    {
        Calculator.Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator.Calculator();
        }

        [Test]
        public void Add_Test()
        {
            int result = calc.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Subtract_Test()
        {
            int result = calc.Subtract(5, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Multiply_Test()
        {
            int result = calc.Multiply(4, 3);
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void Divide_Test()
        {
            int result = calc.Divide(10, 2);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Divide_By_Zero_Test()
        {
            Assert.Throws<System.DivideByZeroException>(() =>
            {
                calc.Divide(10, 0);
            });
        }
    }
}
