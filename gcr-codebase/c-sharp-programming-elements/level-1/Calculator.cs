using System;

class Calculator{

	static void Main(){
	
		Console.Write("Enter first number: "); 
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("sum ="  + (a+b) );
		Console.WriteLine("subtraction =" + (a-b));
		Console.WriteLine("Multiplication =" + (a*b));
		Console.WriteLine("Division =" + (a/b));
	}
}