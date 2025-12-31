using System;

class CelciusToFahrenheit{
    static void Main(){
		// take temperature in celcius as input from user
		Console.Write("Enter temperature in Celcius: ");
        int temp = int.Parse(Console.ReadLine());
		// convert temperature to fahrenheit
        int f = (temp * 9 / 5) + 32;
		// print temperature in fahrenheit
        Console.WriteLine("Temperature in fahrenheit =" + f);
    }
}
