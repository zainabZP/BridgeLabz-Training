using System;

class kilometersToMiles
{
    static void Main()
    {
        double kilometers = double.Parse(Console.ReadLine()); // taking distance in meters as input
        double miles = kilometers * 0.621371; // converting distance from meters to miles
        Console.WriteLine(miles); // printing distance in miles
    }
}
