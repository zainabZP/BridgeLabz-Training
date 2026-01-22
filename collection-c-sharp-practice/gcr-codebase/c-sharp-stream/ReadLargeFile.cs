using System;
using System.IO;

class ReadLargeFile
{
    static void Main()
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";

        if (!File.Exists(inputFile))
        {
            Console.WriteLine("Input file not found");
            return;
        }

        using (StreamReader sr = new StreamReader(inputFile))
        using (StreamWriter sw = new StreamWriter(outputFile))
        {
            string? line;

            while ((line = sr.ReadLine()) != null)
            {
                if (line.ToLower().Contains("error"))
                {
                    Console.WriteLine(line);   // show on console
                    sw.WriteLine(line);        // write to output file
                }
            }
        }

        Console.WriteLine("Filtered lines saved to output.txt");
    }
}
