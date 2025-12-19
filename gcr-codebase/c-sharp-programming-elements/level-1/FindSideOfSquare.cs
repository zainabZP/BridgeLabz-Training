using System;

class FindSideOfSquare
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        double perimeter = double.Parse(input[0]);
        double side =perimeter/4.0;
        Console.WriteLine(side);
    }
}
