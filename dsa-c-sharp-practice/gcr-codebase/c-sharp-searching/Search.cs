using System;

class Search2DMatrix
{
    static bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int low = 0;
        int high = rows * cols - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            int r = mid / cols;
            int c = mid % cols;

            if (matrix[r, c] == target)
                return true;
            else if (matrix[r, c] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return false;
    }

    static void Main()
    {
        int[,] matrix = {
            {1, 3, 5},
            {7, 9, 11},
            {13, 15, 17}
        };

        int target = 9;
        Console.WriteLine("Target Found: " + SearchMatrix(matrix, target));
    }
}
