using System;
using System.Collections.Generic;

// Base class for warehouse items
abstract class Item
{
    public string ItemName = "";
    public int ItemQty;

    public abstract void Show();
}

// Different item types
class ElectronicItem : Item
{
    public override void Show()
    {
        Console.WriteLine("Electronic: " + ItemName + ", Quantity: " + ItemQty);
    }
}

class GroceryItem : Item
{
    public override void Show()
    {
        Console.WriteLine("Grocery: " + ItemName + ", Quantity: " + ItemQty);
    }
}

// Generic storage for any item type
class Warehouse<T> where T : Item
{
    private List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }

    public void ShowAll()
    {
        foreach (T i in list)
            i.Show();
    }
}

class Program
{
    static void Main()
    {
        Warehouse<ElectronicItem> electronics = new Warehouse<ElectronicItem>();
        electronics.Add(new ElectronicItem { ItemName = "Laptop", ItemQty = 10 });

        electronics.ShowAll();
    }
}
