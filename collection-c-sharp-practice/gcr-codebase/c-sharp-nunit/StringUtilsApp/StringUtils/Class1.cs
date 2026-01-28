using System;

namespace StringUtilsApp
{
    public class StringUtils
    {
        public string Reverse(string str)
        {
            if (str == null) return null;
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool IsPalindrome(string str)
        {
            if (str == null) return false;
            string reversed = Reverse(str);
            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        public string ToUpperCase(string str)
        {
            if (str == null) return null;
            return str.ToUpper();
        }
    }
}
