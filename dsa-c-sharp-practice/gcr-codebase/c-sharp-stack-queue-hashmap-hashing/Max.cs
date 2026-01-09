using System;
using System.Collections.Generic;

class SlidingWindow
{
    static void PrintMaxInWindow(int[] arr, int windowSize)
    {
        // Using a deque to store indices of potential maximum elements
        LinkedList<int> dq = new LinkedList<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            // Remove indices that are out of the current window
            if (dq.Count > 0 && dq.First.Value <= i - windowSize)
                dq.RemoveFirst();

            // Remove indices whose values are smaller than current element
            while (dq.Count > 0 && arr[dq.Last.Value] < arr[i])
                dq.RemoveLast();

            // Add current index at the end
            dq.AddLast(i);

            // Print the maximum when the first window is complete
            if (i >= windowSize - 1)
                Console.Write(arr[dq.First.Value] + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int[] numbers = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;

        Console.Write("Maximums in each window: ");
        PrintMaxInWindow(numbers, k);
    }
}
