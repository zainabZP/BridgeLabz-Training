using System;

class EmployeeIdSorter
{
    static void ArrangeIds(int[] numbers)
    {
        for (int pos = 1; pos < numbers.Length; pos++)
        {
            int currentValue = numbers[pos];
            int checkIndex = pos - 1;

            // move bigger values to the right
            while (checkIndex >= 0)
            {
                if (numbers[checkIndex] > currentValue)
                {
                    numbers[checkIndex + 1] = numbers[checkIndex];
                    checkIndex--;
                }
                else
                {
                    break;
                }
            }

            numbers[checkIndex + 1] = currentValue;
        }
    }

    static void Main()
    {
        int[] employeeNumbers = { 105, 101, 110, 102 };

        ArrangeIds(employeeNumbers);

        Console.WriteLine("Employee IDs after sorting:");
        int i = 0;
        while (i < employeeNumbers.Length)
        {
            Console.Write(employeeNumbers[i] + " ");
            i++;
        }
    }
}
