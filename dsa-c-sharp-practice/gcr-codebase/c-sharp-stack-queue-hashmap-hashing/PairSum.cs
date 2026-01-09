using System;
using System.Collections.Generic;

class SumPairChecker
{
    static bool HasPairWithSum(int[] numbers, int targetSum)
    {
        // Using a set to store numbers we've seen
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int num in numbers)
        {
            int complement = targetSum - num;

            // If complement is already seen, we found a pair
            if (seenNumbers.Contains(complement))
            {
                return true;
            }

            // Add current number to the set
            seenNumbers.Add(num);
        }

        // No pair found
        return false;
    }

    static void Main()
    {
        int[] arr = { 1, 4, 5, 7, 9 };
        int target = 10;

        if (HasPairWithSum(arr, target))
            Console.WriteLine("A pair with the target sum exists!");
        else
            Console.WriteLine("No pair found with the target sum.");
    }
}
