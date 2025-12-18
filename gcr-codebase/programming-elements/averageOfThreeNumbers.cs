using System;

class averageOfThreeNumbers
{
    static void Main()
    {
        // taking input from user
        string[] inputs = Console.ReadLine().Split();
        int a = int.Parse(inputs[0]); // first number input
        int b = int.Parse(inputs[1]); // second number input
        int c = int.Parse(inputs[2]); // third number input
        double avg = (a + b + c) / 3.0; // calculating average
        Console.WriteLine(avg); // printing average
    }
}
