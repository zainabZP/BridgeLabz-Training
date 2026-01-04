using System;

class ProductInfo
{
    // instance variables (unique to each product)
    public string itemName;
    public double itemPrice;

    // static variable (shared among all products)
    public static int productCount = 0;

    // constructor
    public ProductInfo(string name, double price)
    {
        itemName = name;
        itemPrice = price;
        productCount++; // increment total products
    }

    // instance method to show product details
    public void showProduct()
    {
        Console.WriteLine("Product : " + itemName);
        Console.WriteLine("Price   : " + itemPrice);
        Console.WriteLine();
    }

    // static method to show total number of products
    public static void showTotalProducts()
    {
        Console.WriteLine("Total Products Created : " + productCount);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // creating product objects
        ProductInfo prod1 = new ProductInfo("Pen", 10);
        ProductInfo prod2 = new ProductInfo("Notebook", 50);

        // display individual product details
        prod1.showProduct();
        prod2.showProduct();

        // display total product count
        ProductInfo.showTotalProducts();
    }
}
