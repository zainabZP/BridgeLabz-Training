using System;

class volumeOfCylinder
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        double r = double.Parse(inputs[0]); // taking radius as input
        double h = double.Parse(inputs[1]); // taking height as input
        double volume = 3.14 * r * r * h; // calculating volume of cylinder
        Console.WriteLine(volume); // printing calculated volume
    }
}
