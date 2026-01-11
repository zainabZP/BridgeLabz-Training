using System;

class ExamScoreSorter
{
    static void ArrangeScores(int[] marks)
    {
        int length = marks.Length;

        for (int position = 0; position < length - 1; position++)
        {
            int smallest = position;

            int scan = position + 1;
            while (scan < length)
            {
                if (marks[scan] < marks[smallest])
                {
                    smallest = scan;
                }
                scan++;
            }

            if (smallest != position)
            {
                int temp = marks[position];
                marks[position] = marks[smallest];
                marks[smallest] = temp;
            }
        }
    }

    static void Main()
    {
        int[] examMarks = { 65, 85, 70, 90 };

        ArrangeScores(examMarks);

        Console.WriteLine("Exam scores after sorting:");
        int i = 0;
        do
        {
            Console.Write(examMarks[i] + " ");
            i++;
        } while (i < examMarks.Length);
    }
}
