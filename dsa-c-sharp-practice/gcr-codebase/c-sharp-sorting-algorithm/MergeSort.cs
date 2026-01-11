using System;

class BookPriceSorter
{
    static void SortPrices(int[] data, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        int center = start + (end - start) / 2;

        SortPrices(data, start, center);
        SortPrices(data, center + 1, end);

        CombineParts(data, start, center, end);
    }

    static void CombineParts(int[] list, int begin, int middle, int finish)
    {
        int leftSize = middle - begin + 1;
        int rightSize = finish - middle;

        int[] leftPart = new int[leftSize];
        int[] rightPart = new int[rightSize];

        for (int x = 0; x < leftSize; x++)
        {
            leftPart[x] = list[begin + x];
        }

        for (int y = 0; y < rightSize; y++)
        {
            rightPart[y] = list[middle + 1 + y];
        }

        int l = 0;
        int r = 0;
        int pos = begin;

        while (l < leftSize && r < rightSize)
        {
            if (leftPart[l] < rightPart[r])
            {
                list[pos] = leftPart[l];
                l++;
            }
            else
            {
                list[pos] = rightPart[r];
                r++;
            }
            pos++;
        }

        while (l < leftSize)
        {
            list[pos++] = leftPart[l++];
        }

        while (r < rightSize)
        {
            list[pos++] = rightPart[r++];
        }
    }

    static void Main()
    {
        int[] bookPrices = { 450, 120, 300, 200 };

        SortPrices(bookPrices, 0, bookPrices.Length - 1);

        Console.WriteLine("Prices after sorting:");
        int i = 0;
        do
        {
            Console.Write(bookPrices[i] + " ");
            i++;
        } while (i < bookPrices.Length);
    }
}
