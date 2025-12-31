using System;

class MyPrimeChecker
{
    static void Main()
    {
        // Ask user to enter a number
        Console.Write("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());

        // Check if number is prime
        bool isPrimeNum = CheckPrime(num);

        // Display result
        if (isPrimeNum)
            Console.WriteLine(num + " is a Prime Number.");
        else
            Console.WriteLine(num + " is NOT a Prime Number.");
    }

    // Method to check prime
    static bool CheckPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
