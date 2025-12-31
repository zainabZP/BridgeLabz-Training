using System;
class FindQuotientAndRemainder {
    public static void Main() {
        // take two numbers as user input
        Console.Write("Enter first number: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int second = Convert.ToInt32(Console.ReadLine());
        // calculating quotient
        int q = first / second;
        // calculating remainder
        int r = first % second;
        // printing quotient and remainder
        Console.WriteLine("Quotient = " + q + " and Remainder = " + r);
    }
}
