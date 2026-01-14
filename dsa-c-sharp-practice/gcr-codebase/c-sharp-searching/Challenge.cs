using System;

class ChallengeProblem
{
    static int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;
        bool[] visited = new bool[n + 1];

        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0 && nums[i] <= n)
                visited[nums[i]] = true;
        }

        for (int i = 1; i <= n; i++)
        {
            if (!visited[i])
                return i;
        }
        return n + 1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }

    static void Main()
    {
        int[] nums = { 3, 4, -1, 1 };
        int target = 4;

        int missing = FirstMissingPositive(nums);
        Array.Sort(nums);
        int index = BinarySearch(nums, target);

        Console.WriteLine("First Missing Positive: " + missing);
        Console.WriteLine("Index of Target: " + index);
    }
}
