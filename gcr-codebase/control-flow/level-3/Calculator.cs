using System;
class Calculator{
    static void Main(){
		// enter two numbers as input and also input an operator as string type
        Console.Write("Enter first number: ");
        double a=double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b=double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        string operation=Console.ReadLine();
		// select operation to be prformed
        switch (operation){
            case "+":
				Console.WriteLine("Result = " +(a+b));
                break;
            case "-":
                Console.WriteLine("Result = " +(a-b));
                break;
            case "*":
                Console.WriteLine("Result = " +(a*b));
                break;
            case "/":
                Console.WriteLine("Result = " +(a/b));
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
