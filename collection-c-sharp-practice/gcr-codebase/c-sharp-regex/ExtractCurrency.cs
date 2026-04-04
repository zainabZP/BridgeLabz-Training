using System;
using System.Text.RegularExpressions;

class ExtractCurrency
{
    public static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50.";
        string pattern = @"\$?\s?\d+(\.\d{1,2})?";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match m in matches)
            Console.WriteLine(m.Value.Trim());
    }
}
