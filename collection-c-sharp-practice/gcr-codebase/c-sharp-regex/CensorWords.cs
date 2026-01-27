using System;
using System.Text.RegularExpressions;

class CensorBadWords
{
    public static void Main()
    {
        string sentence = "This is a damn bad example with some stupid words.";
        string[] badWords = { "damn", "stupid" };

        foreach (string bad in badWords)
        {
            // \b ensures we match whole words only
            string pattern = @"\b" + bad + @"\b";
            sentence = Regex.Replace(sentence, pattern, "****", RegexOptions.IgnoreCase);
        }

        Console.WriteLine(sentence);
    }
}
