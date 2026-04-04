using System;
using System.Collections.Generic;

public class CreatorStats
{
    public string CreatorName { get; set; }
    public double[] WeeklyLikes { get; set; }

    public CreatorStats(string name, double[] likes)
    {
        CreatorName = name;
        WeeklyLikes = likes;
    }
}

public class Program
{
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();

    public void RegisterCreator(CreatorStats record)
    {
        EngagementBoard.Add(record);
        Console.WriteLine("Creator registered successfully");
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (CreatorStats creator in records)
        {
            int count = 0;
            foreach (double likes in creator.WeeklyLikes)
            {
                if (likes >= likeThreshold)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                result[creator.CreatorName] = count;
            }
        }

        return result;
    }

    public double CalculateAverageLikes()
    {
        double total = 0;
        int weeksCount = 0;

        foreach (CreatorStats creator in EngagementBoard)
        {
            foreach (double likes in creator.WeeklyLikes)
            {
                total += likes;
                weeksCount++;
            }
        }

        if (weeksCount == 0) return 0;

        return total / weeksCount;
    }

    public static void Main()
    {
        Program program = new Program();
        while (true)
        {
            Console.WriteLine("\n1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Creator Name: ");
                string name = Console.ReadLine();

                double[] likes = new double[4];
                Console.WriteLine("Enter weekly likes (Week 1 to 4):");
                for (int i = 0; i < 4; i++)
                {
                    likes[i] = Convert.ToDouble(Console.ReadLine());
                }

                CreatorStats creator = new CreatorStats(name, likes);
                program.RegisterCreator(creator);
            }
            else if (choice == "2")
            {
                Console.Write("Enter like threshold: ");
                double threshold = Convert.ToDouble(Console.ReadLine());

                Dictionary<string, int> topPosts = program.GetTopPostCounts(EngagementBoard, threshold);
                if (topPosts.Count == 0)
                {
                    Console.WriteLine("No top-performing posts this week");
                }
                else
                {
                    foreach (KeyValuePair<string, int> kvp in topPosts)
                    {
                        Console.WriteLine(kvp.Key + " - " + kvp.Value);
                    }
                }
            }
            else if (choice == "3")
            {
                double avg = program.CalculateAverageLikes();
                Console.WriteLine("Overall average weekly likes: " + avg);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
