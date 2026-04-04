using System;
using System.Text.RegularExpressions;

class ExtractLanguages
{
    public static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        string pattern = @"\b(Java|Python|JavaScript|Go)\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
