using System;

class MyMaxOfThree
{
    static void Main()
    {
        // Read three numbers from the user
        int firstNum = GetNumber("Enter the first number: ");
        int secondNum = GetNumber("Enter the second number: ");
        int thirdNum = GetNumber("Enter the third number: ");

        // Find the maximum number
        int maxNum = FindMax(firstNum, secondNum, thirdNum);

        // Display the result
        Console.WriteLine("The maximum number is: " + maxNum);
    }

    // Method to read an integer from the user
    static int GetNumber(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    // Method to find the maximum of three numbers
    static int FindMax(int a, int b, int c)
    {
        int max = a;

        if (b > max)
            max = b;

        if (c > max)
            max = c;

        return max;
    }
}
