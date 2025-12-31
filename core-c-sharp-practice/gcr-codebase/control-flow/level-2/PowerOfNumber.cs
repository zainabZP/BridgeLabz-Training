using System;
class PowerOfNumber{
	static void Main(){
		Console.WriteLine("enter number");
		int n=int.Parse(Console.ReadLine());
		Console.WriteLine("enter power");
		int power=int.Parse(Console.ReadLine());
		double r=Math.Pow(n,power);
		Console.WriteLine(n+" to the power "+power+" = "+r);
	}
}