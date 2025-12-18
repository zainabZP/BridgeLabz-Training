using System;

class areaOfCircle
{
    static void Main()
    {
        int radius = int.Parse(Console.ReadLine()); // taking radius as input from user
        double area = 3.14 * (radius * radius); // calculating area of circle
        Console.WriteLine(area); // printing area of circle
    }
}
