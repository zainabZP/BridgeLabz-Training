using System;

class MyGcdLcm
{
    static void Main()
    {
        // Ask user for first number
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        // Ask user for second number
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        // Calculate GCD
        int gcdValue = CalculateGCD(num1, num2);

        // Calculate LCM
        int lcmValue = CalculateLCM(num1, num2, gcdValue);

        // Display results
        Console.WriteLine("GCD of the two numbers: " + gcdValue);
        Console.WriteLine("LCM of the two numbers: " + lcmValue);
    }

    // Method to calculate GCD using Euclidean algorithm
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Method to calculate LCM
    static int CalculateLCM(int a, int b, int gcd)
    {
        return (a * b) / gcd;
    }
}
