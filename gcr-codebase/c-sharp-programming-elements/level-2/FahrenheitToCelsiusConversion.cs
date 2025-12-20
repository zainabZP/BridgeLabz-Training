using System;
class FahrenheitToCelsiusConversion {
    static void Main() {
        Console.Write("Enter temperature in Fahrenheit: ");
        double f = Convert.ToDouble(Console.ReadLine());
        double c =(f-32)*5.0/9.0;
        Console.WriteLine("celcius = "+celcius);
    }
}