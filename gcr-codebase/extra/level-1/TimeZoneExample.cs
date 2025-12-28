using System;

class MyTimeZones
{
    static void Main()
    {
        // Get current UTC time
        DateTimeOffset currentUtc = DateTimeOffset.UtcNow;

        // Define the time zones
        TimeZoneInfo gmt = TimeZoneInfo.Utc;
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Convert UTC to respective time zones
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(currentUtc, gmt);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currentUtc, ist);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currentUtc, pst);

        // Display the times
        Console.WriteLine("Current GMT Time: " + gmtTime);
        Console.WriteLine("Current IST Time: " + istTime);
        Console.WriteLine("Current PST Time: " + pstTime);
    }
}
