using System;

class ConvertPoundsToKilograms{

    static void Main(){
	
        Console.Write("Enter weight in pounds =");
        String[] inp = Console.ReadLine().Split();
        double pounds = Convert.ToDouble(inp[0]);
        double kg = pounds / 2.2;
        Console.WriteLine("The weight in kilograms = " + kg);
    }
}
