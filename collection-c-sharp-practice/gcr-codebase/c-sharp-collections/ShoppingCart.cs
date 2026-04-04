using System;
using System.Collections.Generic;

class ShoppingCart
{
    static void Main()
    {
        Dictionary<string, double> cart = new Dictionary<string, double>();

        cart.Add("Apple", 50);
        cart.Add("Banana", 20);
        cart.Add("Milk", 30);

        foreach (var item in cart)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }
    }
}
