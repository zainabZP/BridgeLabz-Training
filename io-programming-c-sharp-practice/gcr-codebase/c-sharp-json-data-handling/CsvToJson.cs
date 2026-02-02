using System;
using System.IO;

class CsvToJson
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("users.csv");
        string[] headers = lines[0].Split(',');

        string json = "[\n";
        for (int i = 1; i < lines.Length; i++)
        {
            string[] fields = lines[i].Split(',');
            json += "  {\n";
            for (int j = 0; j < headers.Length; j++)
            {
                json += $"    \"{headers[j]}\": \"{fields[j]}\"";
                if (j < headers.Length - 1) json += ",";
                json += "\n";
            }
            json += "  }";
            if (i < lines.Length - 1) json += ",";
            json += "\n";
        }
        json += "]";

        File.WriteAllText("users.json", json);
        Console.WriteLine("CSV converted to JSON!");
    }
}
