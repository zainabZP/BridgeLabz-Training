using System;
class Calculator{
	static int[] calculate(int n,int d) {
		int q=n/d;
		int r=n%d;
		int[] a={q,r};
		return a;
	}
	static void Main(){
		int n=int.Parse(Console.ReadLine());
		int d=int.Parse(Console.ReadLine());
		int[] r=calculate(n,d);
		Console.WriteLine("Quotient = " + r[0]);
        Console.WriteLine("Remainder = " + r[1]);
	}
}
		