using System;
class FindQuotientAndRemainder {
    public static void Main() {
        Console.Write("Enter first number: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int second = Convert.ToInt32(Console.ReadLine());
        int q = first / second;
        int r = first % second;
        Console.WriteLine("Quotient = " + q + " and Remainder = " + r);
    }
}