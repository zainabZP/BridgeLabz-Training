using System;

abstract class Item
{
    public string ItemName;
    public double ItemPrice;
}

class BookItem : Item { }
class DressItem : Item { }

class Shop
{
    public void GiveDiscount<T>(T obj, double percent) where T : Item
    {
        double discount = obj.ItemPrice * percent / 100;
        obj.ItemPrice = obj.ItemPrice - discount;

        Console.WriteLine(obj.ItemName + " price after discount: " + obj.ItemPrice);
    }
}

class Test
{
    static void Main()
    {
        BookItem b = new BookItem();
        b.ItemName = "C# Basics";
        b.ItemPrice = 500;

        Shop s = new Shop();
        s.GiveDiscount(b, 10);
    }
}
