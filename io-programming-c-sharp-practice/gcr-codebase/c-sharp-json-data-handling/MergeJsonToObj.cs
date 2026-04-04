using System;
using System.IO;

class MergeJson
{
    static void Main()
    {
        string json1 = File.ReadAllText("user1.json").Trim();
        string json2 = File.ReadAllText("user2.json").Trim();

        json1 = json1.TrimEnd('}');
        json2 = json2.TrimStart('{');

        string merged = "{\n" + json1 + "," + json2 + "\n}";
        Console.WriteLine("Merged JSON:\n" + merged);
    }
}
