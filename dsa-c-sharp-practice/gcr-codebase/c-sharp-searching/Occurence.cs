using System;

class FirstLastOccurrence
{
    static int FirstOccurrence(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, result = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                high = mid - 1;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return result;
    }

    static int LastOccurrence(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1, result = -1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                low = mid + 1;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return result;
    }

    static void Main()
    {
        int[] arr = { 2, 4, 4, 4, 6, 8 };
        int target = 4;

        Console.WriteLine("First Occurrence: " + FirstOccurrence(arr, target));
        Console.WriteLine("Last Occurrence: " + LastOccurrence(arr, target));
    }
}
