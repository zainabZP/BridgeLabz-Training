using System;

class ProductInfo
{
    // static discount shared by all products
    public static double discountRate = 10;

    // readonly product ID
    public readonly int prodID;
    public string prodName;
    public double prodPrice;
    public int quantity;

    // constructor using 'this' keyword
    public ProductInfo(int prodID, string prodName, double prodPrice, int quantity)
    {
        this.prodID = prodID;
        this.prodName = prodName;
        this.prodPrice = prodPrice;
        this.quantity = quantity;
    }

    // static method to update discount
    public static void updateDiscount(double newDiscount)
    {
        discountRate = newDiscount;
    }

    // method to display product details
    public void showProduct()
    {
        Console.WriteLine("Product Name : " + prodName);
        Console.WriteLine("Price        : " + prodPrice);
        Console.WriteLine("Quantity     : " + quantity);
        Console.WriteLine("Discount     : " + discountRate + "%");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // creating product object
        ProductInfo item1 = new ProductInfo(101, "Laptop", 50000, 1);

        // using 'is' operator for type checking
        if (item1 is ProductInfo)
        {
            item1.showProduct();
        }

        // updating discount
        ProductInfo.updateDiscount(15);

        // display updated discount
        item1.showProduct();
    }
}
