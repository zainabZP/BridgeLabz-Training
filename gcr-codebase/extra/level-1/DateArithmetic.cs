using System;

class MyDateCalc
{
    static void Main()
    {
        // Ask user to enter a date
        Console.Write("Please enter a date in yyyy-MM-dd format: ");
        string userInput = Console.ReadLine();

        DateTime startDate = DateTime.Parse(userInput);

        // Add 7 days
        DateTime tempDate = startDate.AddDays(7);

        // Add 1 month
        tempDate = tempDate.AddMonths(1);

        // Add 2 years
        tempDate = tempDate.AddYears(2);

        // Subtract 3 weeks (21 days)
        tempDate = tempDate.AddDays(-21);

        // Show final date
        Console.WriteLine("The calculated date is: " + tempDate.ToShortDateString());
    }
}
