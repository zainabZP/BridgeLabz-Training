using System;

class MyFactorialCalculator
{
    static void Main()
    {
        // Ask user to enter a number
        Console.Write("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());

        // Calculate factorial
        long fact = CalculateFactorial(num);

        // Display result
        Console.WriteLine("Factorial of " + num + " is: " + fact);
    }

    // Recursive method to calculate factorial
    static long CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * CalculateFactorial(n - 1);
    }
}
