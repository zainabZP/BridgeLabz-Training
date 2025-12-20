using System;
class CalculateSimpleInterest{
    static void Main(){
        Console.Write("Enter principal, rate and time: ");
        string[] inp=Console.ReadLine().Split();
        double p=Convert.ToDouble(inp[0]);
        double r=Convert.ToDouble(inp[1]);
        double t=Convert.ToDouble(inp[2]);
        double simpleInterest=(p*r*t)/100;
        Console.WriteLine("Simple Interest = " + simpleInterest);
    }
}
