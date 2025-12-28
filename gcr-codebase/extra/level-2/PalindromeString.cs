using System;

class MyPalindromeChecker
{
    static void Main()
    {
        // Ask user to enter a string
        string userInput = GetInput();

        // Check if it is a palindrome
        bool isPal = CheckPalindrome(userInput);

        // Show result
        ShowResult(isPal);
    }

    // Method to read input from user
    static string GetInput()
    {
        Console.Write("Please enter a string: ");
        return Console.ReadLine();
    }

    // Method to check palindrome
    static bool CheckPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    // Method to display result
    static void ShowResult(bool palindrome)
    {
        if (palindrome)
            Console.WriteLine("The string is a Palindrome!");
        else
            Console.WriteLine("The string is NOT a Palindrome.");
    }
}
