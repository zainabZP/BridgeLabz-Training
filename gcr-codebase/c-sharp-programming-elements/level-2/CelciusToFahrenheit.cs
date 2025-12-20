using System;

class CelciusToFahrenheit{
    static void Main(){
		Console.Write("Enter temperature in Celcius: ");
        int temp = int.Parse(Console.ReadLine());
        int f = (temp * 9 / 5) + 32;
        Console.WriteLine("Temperature in fahrenheit =" + f);
    }
}
