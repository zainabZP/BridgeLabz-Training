using System;

class AadharRadixSort
{
    static void Main()
    {
        long[] aadhar = {
            123456789012,
            123450009999,
            987654321012,
            123456780000,
            555544443333
        };

        RadixSort(aadhar);

        Console.WriteLine("Sorted Aadhar Numbers:");
        for (int i = 0; i < aadhar.Length; i++)
        {
            Console.WriteLine(aadhar[i]);
        }

        long key = 987654321012;
        int pos = BinarySearch(aadhar, key);

        if (pos != -1)
            Console.WriteLine("Aadhar found at index " + pos);
        else
            Console.WriteLine("Aadhar not found");
    }

    static void RadixSort(long[] arr)
    {
        long max = arr[0];
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] > max)
                max = arr[i];

        for (long exp = 1; max / exp > 0; exp *= 10)
            CountSort(arr, exp);
    }

    static void CountSort(long[] arr, long exp)
    {
        int n = arr.Length;
        long[] output = new long[n];
        int[] count = new int[10];

        for (int i = 0; i < n; i++)
            count[(int)((arr[i] / exp) % 10)]++;

        for (int i = 1; i < 10; i++)
            count[i] += count[i - 1];

        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (int)((arr[i] / exp) % 10);
            output[count[digit] - 1] = arr[i];
            count[digit]--;
        }

        for (int i = 0; i < n; i++)
            arr[i] = output[i];
    }

    static int BinarySearch(long[] arr, long key)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }
}
