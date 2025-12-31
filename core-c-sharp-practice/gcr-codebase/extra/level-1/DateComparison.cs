using System;

class MyDateChecker
{
    static void Main()
    {
        // Ask user to enter the first date
        Console.Write("Enter the first date (yyyy-MM-dd): ");
        string firstInput = Console.ReadLine();
        DateTime firstDate = DateTime.Parse(firstInput);

        // Ask user to enter the second date
        Console.Write("Enter the second date (yyyy-MM-dd): ");
        string secondInput = Console.ReadLine();
        DateTime secondDate = DateTime.Parse(secondInput);

        // Compare the two dates
        int compareResult = DateTime.Compare(firstDate, secondDate);

        // Display the result
        if (compareResult < 0)
        {
            Console.WriteLine("The first date comes before the second date.");
        }
        else if (compareResult > 0)
        {
            Console.WriteLine("The first date comes after the second date.");
        }
        else
        {
            Console.WriteLine("Both dates are the same.");
        }
    }
}
