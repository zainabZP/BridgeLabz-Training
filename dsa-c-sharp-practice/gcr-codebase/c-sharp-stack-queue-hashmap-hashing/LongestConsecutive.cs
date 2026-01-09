using System;
using System.Collections.Generic;

class ConsecutiveNumbers
{
    static int LongestSequenceLength(int[] numbers)
    {
        // Put all numbers in a set for quick lookup
        HashSet<int> numberSet = new HashSet<int>(numbers);
        int maxLength = 0;

        foreach (int n in numbers)
        {
            // Only start counting if this number is the start of a sequence
            if (!numberSet.Contains(n - 1))
            {
                int currentNum = n;
                int sequenceLen = 1;

                // Count consecutive numbers
                while (numberSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    sequenceLen++;
                }

                // Update longest sequence found so far
                if (sequenceLen > maxLength)
                    maxLength = sequenceLen;
            }
        }

        return maxLength;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        int result = LongestSequenceLength(arr);
        Console.WriteLine("Length of longest consecutive sequence: " + result);
    }
}
