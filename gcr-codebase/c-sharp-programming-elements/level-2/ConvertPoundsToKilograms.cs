using System;

class ConvertPoundsToKilograms{

    static void Main(){

		// take weight in pounds as input from use
        Console.Write("Enter weight in pounds =");
        String[] inp = Console.ReadLine().Split();
        double pounds = Convert.ToDouble(inp[0]);
		// convert pounds to kilogram
        double kg = pounds / 2.2;
		// print converted weight in kg
        Console.WriteLine("The weight in kilograms = " + kg);
    }
}
