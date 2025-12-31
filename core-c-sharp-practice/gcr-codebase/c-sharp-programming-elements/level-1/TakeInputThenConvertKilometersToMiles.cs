using System;

class TakeInputThenConvertKilometersToMiles{
	static void Main(){
		//taking distance in km as user input
		Console.Write("Enter distance in km =");
        double kilometer=Convert.ToDouble(Console.ReadLine());
		//converting distance to miles
        double miles=kilometer/1.6;
		// printing calculated miles
        Console.WriteLine("miles =" + miles);
	}
}
