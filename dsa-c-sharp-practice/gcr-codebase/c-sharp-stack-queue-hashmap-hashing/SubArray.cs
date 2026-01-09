using System;
using System.Collections.Generic;

class ZeroSumChecker
{
    static bool HasZeroSumSubarray(int[] arr)
    {
        HashSet<int> sums = new HashSet<int>();
        int currentSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            currentSum += arr[i];

            // If sum is zero or we have seen this sum before
            if (currentSum == 0 || sums.Contains(currentSum))
                return true;

            sums.Add(currentSum);
        }

        return false;
    }

    static void Main()
    {
        int[] arr = { 4, -2, -2, 1 };

        if (HasZeroSumSubarray(arr))
            Console.WriteLine("There is a zero-sum subarray.");
        else
            Console.WriteLine("No zero-sum subarray found.");
    }
}
