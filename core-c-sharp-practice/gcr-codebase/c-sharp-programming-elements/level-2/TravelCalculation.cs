using System;
class TravelCalculation{
    static void Main()
    {
        // taking person name as input from use
        Console.Write("Enter name : ");
        String name = Console.ReadLine();
		
        // taking city names as input from user
		
        Console.Write("Enter from city : ");
        string from = Console.ReadLine(); // from city
		
        Console.Write("Enter via city : ");
        string via = Console.ReadLine(); // via city
		
        Console.Write("Enter to city : ");
        string to = Console.ReadLine(); // to city
		
        // taking distances in miles as input from user
		
        Console.Write("Enter distance from " + from + " to " + via + " : ");
        double fromCityToViaCity = Convert.ToDouble(Console.ReadLine());
		
        Console.Write("Enter distance from " + via + " to " + to + " : ");
        double viaCityToFinalCity = Convert.ToDouble(Console.ReadLine());
		
        // taking time in min as input from user
        Console.Write("Enter time taken in minutes: ");
        int time = Convert.ToInt32(Console.ReadLine());
		
        // calculating total distance
        double totalDist = fromCityToViaCity + viaCityToFinalCity;

        // printing final result
        Console.WriteLine($"The Total Distance travelled by {name} from {from} to {to} via {via} is {totalDist} km and the Total Time taken is {time} minutes");
    }
}
