using System;

class celciusToFahrenheit
{
    static void Main()
    {
        int temp = int.Parse(Console.ReadLine()); // taking temperature as input
        int f = (temp * 9 / 5) + 32; // converting cecius to fahrenheit
        Console.WriteLine(f); // printing temperature in fahrenheit
    }
}
