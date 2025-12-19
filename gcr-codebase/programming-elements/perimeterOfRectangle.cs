using System;

class perimeterOfRectangle
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        double length = double.Parse(inputs[0]); // taking length as input from user
        double breadth = double.Parse(inputs[1]); // taking breadth as input from user
        double perimeter = 2 * (length + breadth); // calculating perimeter of rectange
        Console.WriteLine(perimeter); // printing calculated perimeter
    }
}
