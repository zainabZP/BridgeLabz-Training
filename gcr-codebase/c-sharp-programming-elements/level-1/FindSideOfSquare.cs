using System;

class FindSideOfSquare
{
    static void Main()
    {
        // taking perimeter as input from user
        Console.Write("Enter perimeter: ");
        string[] input = Console.ReadLine().Split();
        double perimeter = double.Parse(input[0]);
        // calculating length of one side of square
        double side =perimeter/4.0;
        // printing length of one side
        Console.WriteLine("one side = "+side);
    }
}
