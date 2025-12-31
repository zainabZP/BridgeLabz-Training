using System;

class MyFibonacci
{
    static void Main()
    {
        // Ask user for number of terms
        Console.Write("Enter how many terms you want: ");
        int totalTerms = int.Parse(Console.ReadLine());

        // Print the Fibonacci series
        ShowFibonacciSeries(totalTerms);
    }

    // Method to print Fibonacci series
    static void ShowFibonacciSeries(int n)
    {
        int first = 0;
        int second = 1;

        Console.Write("Fibonacci Series: ");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(first + " ");
            int nextTerm = first + second;
            first = second;
            second = nextTerm;
        }
    }
}
