using System;
using System.Collections.Generic;

class TwoSumSolver
{
    static int[] FindTwoSum(int[] numbers, int target)
    {
        // Dictionary to store value -> index
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int complement = target - numbers[i];

            // Check if we have seen the complement before
            if (seen.ContainsKey(complement))
            {
                return new int[] { seen[complement], i };
            }

            // Store current number with its index
            seen[numbers[i]] = i;
        }

        // No pair found
        return null;
    }

    static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = FindTwoSum(arr, target);

        if (result != null)
            Console.WriteLine("Indices: " + result[0] + ", " + result[1]);
        else
            Console.WriteLine("No pair found.");
    }
}
