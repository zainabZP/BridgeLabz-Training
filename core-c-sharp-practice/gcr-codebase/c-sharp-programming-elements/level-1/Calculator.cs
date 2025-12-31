using System;

class Calculator{

	static void Main(){

		// taking two numbers asuser input to perform basic operations of a calculator
		Console.Write("Enter first number: "); 
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("sum ="  + (a+b) ); // calculating and printing addition of two numbers
		Console.WriteLine("subtraction =" + (a-b)); // calculating and printing subtraction of two numbers
		Console.WriteLine("Multiplication =" + (a*b)); // calculating and printing multiplication of two numbers
		Console.WriteLine("Division =" + (a/b)); // calculating and printing division of two numbers
	}
}
