using System;

class ConvertDistanceIntoYardsAndMiles{
	static void Main(){

		// taking distance in feet as user input 
		String[] input=Console.ReadLine().Split();
		int distanceInFeet=int.Parse(input[0]);
		// converting distance to yards and then to miles
		
		double yards=(double)distanceInFeet/3.0; // 1 yard is 3 feet
		double miles=yards/1760; // 1 mile = 1760 yards

		// printing distance after conversion
		Console.WriteLine("yards="+yards);
		Console.WriteLine("miles="+miles);
	}
}
		
