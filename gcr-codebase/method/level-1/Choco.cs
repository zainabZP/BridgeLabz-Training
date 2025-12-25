

using System;
class Choco
{
	public static int[] FindRemainderAndQuotient(int number, int divisor)
	{
		int g=number/divisor;
		int r=number%divisor;
		return new int [] {g,r};
	}
	static void Main()
	{
		int number=int.Parse(Console.ReadLine());
		int divisor=int.Parse(Console.ReadLine());
		int [] result=FindRemainderAndQuotient(number,divisor);
		Console.WriteLine(result[0]);
		Console.WriteLine(result[1]);
	}
}
		
		
		