using System;
class FahrenheitToCelsiusConversion {
    static void Main() {
        // take temperature in fahrenheit as user input
        Console.Write("Enter temperature in Fahrenheit: ");
        double f = Convert.ToDouble(Console.ReadLine());
        // convert temperature to celcius
        double c =(f-32)*5.0/9.0;
        // print temperature in celcius
        Console.WriteLine("celcius = "+celcius);
    }
}
