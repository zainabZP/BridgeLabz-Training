using System;
class SwapNumbers {	
    public static void Main(string[] args) {
		// taking two numbers as input from user
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
		//swapping numbers
        int t = a;
        a = b;
		b = t;
		// printing new values of both numbers
        Console.WriteLine("final a = "+a);
		Console.WriteLine("final b = "+b);
    }
}
