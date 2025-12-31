using System;

class calculateSimpleInterest
{
    static void Main()
    {
        // taking input from user
        string[] inputs = Console.ReadLine().Split();
        int p = int.Parse(inputs[0]); // taking principle as input
        int r = int.Parse(inputs[1]); // taking rate as input
        int t = int.Parse(inputs[2]); // taking time as input
        double SI = (p * r * t) / 100.0; // calculating simple interest
        Console.WriteLine(SI); // printing simple interest
    }
}
