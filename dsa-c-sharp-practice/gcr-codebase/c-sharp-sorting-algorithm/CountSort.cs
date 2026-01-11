using System;

class AgeSorterProgram
{
    static void SortAges(int[] ageArray)
    {
        int lowerAge = 10;
        int upperAge = 18;

        int size = upperAge - lowerAge + 1;
        int[] frequency = new int[size];

        // store how many times each age occurs
        for (int i = 0; i < ageArray.Length; i++)
        {
            int position = ageArray[i] - lowerAge;
            frequency[position]++;
        }

        int pointer = 0;

        // place ages back into original array
        for (int i = 0; i < frequency.Length; i++)
        {
            int times = frequency[i];

            while (times > 0)
            {
                ageArray[pointer] = i + lowerAge;
                pointer++;
                times--;
            }
        }
    }

    static void Main()
    {
        int[] studentAges = { 12, 15, 10, 14, 12 };

        SortAges(studentAges);

        Console.WriteLine("Ages after sorting:");
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write(studentAges[i] + " ");
        }
    }
}
