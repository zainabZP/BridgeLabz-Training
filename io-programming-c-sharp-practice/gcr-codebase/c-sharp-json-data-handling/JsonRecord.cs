using System;
using System.IO;

class Record
{
    public string Name;
    public int Score;
}

class GenerateJsonReport
{
    static void Main()
    {
        Record[] records = new Record[]
        {
            new Record { Name="Aman", Score=80 },
            new Record { Name="Riya", Score=90 },
            new Record { Name="Luna", Score=85 }
        };

        string json = "[\n";
        for (int i = 0; i < records.Length; i++)
        {
            json += "  {\n" +
                    "    \"Name\": \"" + records[i].Name + "\",\n" +
                    "    \"Score\": " + records[i].Score + "\n" +
                    "  }";
            if (i < records.Length - 1) json += ",";
            json += "\n";
        }
        json += "]";

        File.WriteAllText("report.json", json);
        Console.WriteLine("JSON report generated!");
    }
}
