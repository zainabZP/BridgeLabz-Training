using System;

class MaximumHandshake
{
    static void Main()
    {
        Console.Write("Enter number of people: ");
        string[] inputs = Console.ReadLine().Split();
        int n = int.Parse(inputs[0]);
        // calculating maximum number of handshakes possible
        double maxHandshake=(double)(n * (n - 1)) / 2.0;
        // printing maximum handshake
        Console.WriteLine(maxHandshake);
    }
}
