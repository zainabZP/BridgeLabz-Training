using System;
class SwapNumbers {	
    public static void Main(string[] args) {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int t = a;
        a = b;
		b = t;
        Console.WriteLine("final a = "+a);
		Console.WriteLine("final b = "+b);
    }
}