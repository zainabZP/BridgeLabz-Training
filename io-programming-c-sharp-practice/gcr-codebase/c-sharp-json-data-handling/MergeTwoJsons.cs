using System;
using System.IO;

class MergeTwoJson
{
    static void Main()
    {
        // Read the first JSON
        string json1 = File.ReadAllText("user.json");

        // Read the second JSON
        string json2 = File.ReadAllText("user2.json");

        // Remove the closing } from json1
        json1 = json1.TrimEnd('}', '\n', ' ');

        // Remove the opening { from json2
        json2 = json2.TrimStart('{', '\n', ' ');

        // Merge manually
        string merged = json1 + "," + json2;
        merged = "{\n" + merged + "\n}";

        Console.WriteLine("Merged JSON:\n" + merged);
    }
}
