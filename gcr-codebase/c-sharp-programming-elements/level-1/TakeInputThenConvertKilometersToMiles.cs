using System;

class TakeInputThenConvertKilometersToMiles{
	static void Main(){
		Console.Write("Enter distance in km =");
        double kilometer=Convert.ToDouble(Console.ReadLine());
        double miles=kilometer/1.6;
        Console.WriteLine("miles =" + miles);
	}
}