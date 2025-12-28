using System;

class MyDateFormatter
{
    static void Main()
    {
        // Get the current date and time
        DateTime currentDate = DateTime.Now;

        // Show date in different formats
        Console.WriteLine("Format 1 (dd/MM/yyyy): " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Format 2 (yyyy-MM-dd): " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Format 3 (EEE, MMM dd, yyyy): " + currentDate.ToString("ddd, MMM dd, yyyy"));
    }
}
