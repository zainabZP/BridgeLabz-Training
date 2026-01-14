using System;

class PeakElement
{
    static int FindPeak(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] < arr[mid + 1])
                low = mid + 1;
            else
                high = mid;
        }
        return low;
    }

    static void Main()
    {
        int[] arr = { 1, 3, 20, 4, 1, 0 };
        int index = FindPeak(arr);

        Console.WriteLine("Peak Element: " + arr[index]);
        Console.WriteLine("Peak Index: " + index);
    }
}
