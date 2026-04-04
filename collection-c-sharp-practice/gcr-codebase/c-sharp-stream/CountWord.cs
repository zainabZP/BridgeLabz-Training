using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class WordCount
{
    static void Main()
    {
        Dictionary<string, int> wordsCount = new Dictionary<string, int>();

        try
        {
            // input.txt must be in the SAME folder as this .cs file
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                string? line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', ',', '.', '!', '?');

                    foreach (string w in words)
                    {
                        if (w.Length == 0)
                            continue;

                        string word = w.ToLower();

                        if (wordsCount.ContainsKey(word))
                            wordsCount[word]++;
                        else
                            wordsCount[word] = 1;
                    }
                }
            }

            var top5 = wordsCount
                        .OrderByDescending(x => x.Value)
                        .Take(5);

            Console.WriteLine("Top 5 frequent words:");
            foreach (var item in top5)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("File error: " + e.Message);
        }
    }
}
