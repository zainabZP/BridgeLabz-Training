using System;
class DistributeChocolates{
	
    public static void Main(){

		// Take total chocolates and number of children as inputs from user
        Console.Write("Enter Total Chocolates and Children : ");
        string[] inputs = Console.ReadLine().Split();
        int chocolates = int.Parse(inputs[0]);
        int children = int.Parse(inputs[1]);
		// calculate chocolates per child
        int chocolatesPerChild=(chocolates/children);
		// calculate chocolates left undivided
        int chocolatesLeft = (chocolates % children);
		// print chocolates per child and chocolates left undivided
        Console.WriteLine("chocolates Per Child = " + chocolatesPerChild);
		Console.WriteLine("chocolates left = " + chocolatesLeft);
    }
}
