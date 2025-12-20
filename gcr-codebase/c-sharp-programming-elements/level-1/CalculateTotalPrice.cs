using System;

class CalculateTotalPrice
{
    static void Main()
    {
        // taking user input for unit price and quantity of product.
        string[] inputs = Console.ReadLine().Split();
        int unitPrice = int.Parse(inputs[0]);
        int quantity = int.Parse(inputs[1]);
        // calculating total bill
        int totalPrice = unitPrice*quantity;
        // printing bill
        Console.WriteLine(totalPrice);
    }
}
