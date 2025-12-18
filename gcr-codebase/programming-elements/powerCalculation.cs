using System;

class powerCalculation
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        double e = double.Parse(inputs[0]); // taking power as input
        double b = double.Parse(inputs[1]); // taking base as input
        double result = Math.Pow(b, e); // calculating base to the power e
        Console.WriteLine(result); // printing calculated result
    }
}
