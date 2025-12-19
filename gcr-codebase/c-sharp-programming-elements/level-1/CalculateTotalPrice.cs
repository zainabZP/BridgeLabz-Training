using System;

class CalculateTotalPrice
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int unitPrice = int.Parse(inputs[0]);
        int quantity = int.Parse(inputs[1]);
        int totalPrice = unitPrice*quantity;
        Console.WriteLine(totalPrice);
    }
}
