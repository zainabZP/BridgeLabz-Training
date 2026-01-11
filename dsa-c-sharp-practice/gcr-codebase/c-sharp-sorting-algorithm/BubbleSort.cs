using System;

class MarksOrderProgram
{
    static void ArrangeMarks(int[] data)
    {
        int total = data.Length;

        for (int round = 1; round < total; round++)
        {
            for (int pos = 0; pos < total - round; pos++)
            {
                if (data[pos] > data[pos + 1])
                {
                    // manual swap
                    int holder = data[pos + 1];
                    data[pos + 1] = data[pos];
                    data[pos] = holder;
                }
            }
        }
    }

    static void Main()
    {
        int[] marksList = { 78, 45, 89, 60, 72 };

        ArrangeMarks(marksList);

        Console.WriteLine("Final sorted marks:");
        int index = 0;
        while (index < marksList.Length)
        {
            Console.Write(marksList[index] + " ");
            index++;
        }
    }
}
