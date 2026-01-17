using System;

class Product
{
    public int id;
    public string name;
    public double discount; // percentage

    public Product(int id, string name, double discount)
    {
        this.id = id;
        this.name = name;
        this.discount = discount;
    }
}

class FlashDealz
{
    private Product[] products;

    public FlashDealz(int size)
    {
        products = new Product[size];
    }

    public void Set(Product p, int i)
    {
        products[i] = p;
    }

    public Product[] Get()
    {
        return products;
    }

    public void QuickSort(int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(low, high);
            QuickSort(low, pi - 1);
            QuickSort(pi + 1, high);
        }
    }

    private int Partition(int low, int high)
    {
        double pivot = products[high].discount;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (products[j].discount >= pivot) // sort descending for top discounts
            {
                i++;
                Product temp = products[i];
                products[i] = products[j];
                products[j] = temp;
            }
        }

        Product t = products[i + 1];
        products[i + 1] = products[high];
        products[high] = t;

        return i + 1;
    }

    public void Display()
    {
        Console.WriteLine("Top Discount Products:");
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i] != null)
                Console.WriteLine(products[i].name + " - " + products[i].discount + "% OFF");
        }
    }
}

class Program
{
    public static void Main()
    {
        FlashDealz flash = new FlashDealz(5);

        flash.Set(new Product(1, "Laptop", 20), 0);
        flash.Set(new Product(2, "Smartphone", 35), 1);
        flash.Set(new Product(3, "Headphones", 50), 2);
        flash.Set(new Product(4, "Smartwatch", 25), 3);
        flash.Set(new Product(5, "Camera", 40), 4);

        Console.WriteLine("Before Sorting:");
        flash.Display();

        flash.QuickSort(0, flash.Get().Length - 1);

        Console.WriteLine("\nAfter Sorting by Discount:");
        flash.Display();
    }
}
