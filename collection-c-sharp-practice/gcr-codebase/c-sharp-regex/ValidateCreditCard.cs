using System;
using System.Text.RegularExpressions;

class ValidateCard
{
    public static void Main()
    {
        string card = "4111222233334444";
        string visaPattern = @"^4\d{15}$";           // Visa: starts with 4, 16 digits
        string masterPattern = @"^5\d{15}$";         // MasterCard: starts with 5, 16 digits

        if (Regex.IsMatch(card, visaPattern))
            Console.WriteLine("Valid Visa Card");
        else if (Regex.IsMatch(card, masterPattern))
            Console.WriteLine("Valid MasterCard");
        else
            Console.WriteLine("Invalid Card");
    }
}
