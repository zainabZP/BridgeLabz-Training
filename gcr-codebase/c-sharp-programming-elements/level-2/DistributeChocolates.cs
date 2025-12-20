using System;
class DistributeChocolates{
	
    public static void Main(){

        Console.Write("Enter Total Chocolates and Children : ");
        string[] inputs = Console.ReadLine().Split();
        int chocolates = int.Parse(inputs[0]);
        int children = int.Parse(inputs[1]);
        int chocolatesPerChild=(chocolates/children);
        int chocolatesLeft = (chocolates % children);
        Console.WriteLine("chocolates Per Child = " + chocolatesPerChild);
		Console.WriteLine("chocolates left = " + chocolatesLeft);
    }
}