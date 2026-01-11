using System;

class ProductPriceSorter
{
    static void SortPrices(int[] list, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        int splitPoint = Rearrange(list, start, end);

        SortPrices(list, start, splitPoint - 1);
        SortPrices(list, splitPoint + 1, end);
    }

    static int Rearrange(int[] values, int begin, int finish)
    {
        int reference = values[finish];
        int boundary = begin;

        for (int current = begin; current < finish; current++)
        {
            if (values[current] <= reference)
            {
                int temp = values[boundary];
                values[boundary] = values[current];
                values[current] = temp;
                boundary++;
            }
        }

        int holder = values[boundary];
        values[boundary] = values[finish];
        values[finish] = holder;

        return boundary;
    }

    static void Main()
    {
        int[] productPrices = { 999, 499, 799, 299 };

        SortPrices(productPrices, 0, productPrices.Length - 1);

        Console.WriteLine("Prices after sorting:");
        int i = 0;
        while (i < productPrices.Length)
        {
            Console.Write(productPrices[i] + " ");
            i++;
        }
    }
}
