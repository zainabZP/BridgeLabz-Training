using System;
using System.Text.RegularExpressions;

class ValidateSSN
{
    public static void Main()
    {
        string ssn = "123-45-6789";
        string pattern = @"^\d{3}-\d{2}-\d{4}$";

        bool valid = Regex.IsMatch(ssn, pattern);
        Console.WriteLine(valid ? "Valid SSN" : "Invalid SSN");
    }
}
