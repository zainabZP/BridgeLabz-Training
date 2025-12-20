using System;
class CalculateSimpleInterest{
    static void Main(){
        // taking principal, rate and time as user input
        Console.Write("Enter principal, rate and time: ");
        string[] inp=Console.ReadLine().Split();
        double p=Convert.ToDouble(inp[0]);
        double r=Convert.ToDouble(inp[1]);
        double t=Convert.ToDouble(inp[2]);
        // calculating simple interes
        double simpleInterest=(p*r*t)/100;
        // printing calculated SI
        Console.WriteLine("Simple Interest = " + simpleInterest);
    }
}
