using System;
using System.Text.RegularExpressions;

class RepeatingWords
{
    public static void Main()
    {
        string text = "This is is a repeated repeated word test.";
        string pattern = @"\b(\w+)\s+\1\b";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        foreach (Match m in matches)
            Console.WriteLine(m.Groups[1].Value);
    }
}
