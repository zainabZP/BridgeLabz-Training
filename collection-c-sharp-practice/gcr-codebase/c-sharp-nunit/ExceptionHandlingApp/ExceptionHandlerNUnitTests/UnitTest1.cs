using NUnit.Framework;
using ExceptionHandler;  // namespace of main project
using System;

namespace ExceptionHandlerNUnitTests
{
    [TestFixture]
    public class DivideTests
    {
        [Test]
        public void Divide_ByNonZero_ReturnsQuotient()
        {
            var handler = new ExceptionHandler.ExceptionHandler(); // FIXED
            int result = handler.Divide(10, 2);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            var handler = new ExceptionHandler.ExceptionHandler(); // FIXED
            Assert.Throws<ArithmeticException>(() => handler.Divide(10, 0));
        }
    }
}
