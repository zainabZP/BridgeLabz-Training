using System;

class MyTemperatureConverter
{
    static void Main()
    {
        // Ask user to enter temperature
        Console.Write("Enter the temperature: ");
        double tempValue = double.Parse(Console.ReadLine());

        // Ask user for conversion choice
        Console.Write("Convert to Celsius (C) or Fahrenheit (F)? ");
        char choice = Char.ToUpper(Console.ReadLine()[0]);

        // Perform conversion based on choice
        if (choice == 'C')
        {
            double celsius = ConvertFtoC(tempValue);
            Console.WriteLine("Temperature in Celsius: " + celsius);
        }
        else if (choice == 'F')
        {
            double fahrenheit = ConvertCtoF(tempValue);
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }

    // Convert Fahrenheit to Celsius
    static double ConvertFtoC(double f)
    {
        return (f - 32) * 5 / 9;
    }

    // Convert Celsius to Fahrenheit
    static double ConvertCtoF(double c)
    {
        return (c * 9 / 5) + 32;
    }
}
