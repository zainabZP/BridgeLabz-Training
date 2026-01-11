using System;

class SalarySortProgram
{
    static void SortSalaryData(int[] values)
    {
        int length = values.Length;

        // create max heap
        for (int start = (length / 2) - 1; start >= 0; start--)
        {
            AdjustHeap(values, length, start);
        }

        // move largest element to end one by one
        int end = length - 1;
        while (end > 0)
        {
            int temp = values[0];
            values[0] = values[end];
            values[end] = temp;

            AdjustHeap(values, end, 0);
            end--;
        }
    }

    static void AdjustHeap(int[] data, int size, int root)
    {
        int big = root;
        int leftChild = (2 * root) + 1;
        int rightChild = (2 * root) + 2;

        if (leftChild < size && data[leftChild] > data[big])
        {
            big = leftChild;
        }

        if (rightChild < size && data[rightChild] > data[big])
        {
            big = rightChild;
        }

        if (big != root)
        {
            int swap = data[root];
            data[root] = data[big];
            data[big] = swap;

            AdjustHeap(data, size, big);
        }
    }

    static void Main()
    {
        int[] monthlySalaries = { 50000, 30000, 70000, 40000 };

        SortSalaryData(monthlySalaries);

        Console.WriteLine("Salaries after sorting:");
        int i = 0;
        do
        {
            Console.Write(monthlySalaries[i] + " ");
            i++;
        } while (i < monthlySalaries.Length);
    }
}
