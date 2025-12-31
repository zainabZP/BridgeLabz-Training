using System;

class SimpleCalculator
{
    static void Main()
    {
        // Ask for first number
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        // Ask for second number
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        // Ask for operation
        Console.Write("Choose an operation (+, -, *, /): ");
        char operation = Console.ReadLine()[0];

        // Calculate result
        double answer = PerformCalculation(num1, num2, operation);

        // Display the result
        Console.WriteLine("Result: " + answer);
    }

    // Function to perform calculation based on operation
    static double PerformCalculation(double x, double y, char op)
    {
        if (op == '+')
            return Sum(x, y);
        else if (op == '-')
            return Difference(x, y);
        else if (op == '*')
            return Product(x, y);
        else if (op == '/')
            return Quotient(x, y);

        // If invalid operation
        return 0;
    }

    // Individual operations
    static double Sum(double a, double b) { return a + b; }
    static double Difference(double a, double b) { return a - b; }
    static double Product(double a, double b) { return a * b; }
    static double Quotient(double a, double b) { return a / b; }
}
