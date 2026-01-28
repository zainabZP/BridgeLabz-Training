using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilsApp;  // your main class namespace

namespace StringUtilsMSTests
{
    [TestClass]
    public class StringUtilsTests
    {
        [TestMethod]
        public void Reverse_Test()
        {
            StringUtils utils = new StringUtils();
            string result = utils.Reverse("hello");
            Assert.AreEqual("olleh", result);
        }

        [TestMethod]
        public void IsPalindrome_Test()
        {
            StringUtils utils = new StringUtils();
            bool result1 = utils.IsPalindrome("madam");
            bool result2 = utils.IsPalindrome("hello");

            Assert.IsTrue(result1);   // madam is palindrome
            Assert.IsFalse(result2);  // hello is not palindrome
        }

        [TestMethod]
        public void ToUpperCase_Test()
        {
            StringUtils utils = new StringUtils();
            string result = utils.ToUpperCase("hello");
            Assert.AreEqual("HELLO", result);
        }
    }
}
