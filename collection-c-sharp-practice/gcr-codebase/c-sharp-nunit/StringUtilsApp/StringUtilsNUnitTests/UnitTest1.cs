using NUnit.Framework;
using StringUtilsApp;  // your main class namespace

namespace StringUtilsNUnitTests
{
    [TestFixture]  // required for NUnit
    public class StringUtilsTests
    {
        [Test]
        public void Reverse_Test()
        {
            StringUtils utils = new StringUtils();
            string result = utils.Reverse("hello");
            Assert.That(result, Is.EqualTo("olleh"));
        }

        [Test]
        public void IsPalindrome_Test()
        {
            StringUtils utils = new StringUtils();
            bool result1 = utils.IsPalindrome("madam");
            bool result2 = utils.IsPalindrome("hello");

            Assert.That(result1, Is.True);
            Assert.That(result2, Is.False);
        }

        [Test]
        public void ToUpperCase_Test()
        {
            StringUtils utils = new StringUtils();
            string result = utils.ToUpperCase("hello");
            Assert.That(result, Is.EqualTo("HELLO"));
        }
    }
}
