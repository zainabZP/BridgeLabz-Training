using System;
using System.IO;

class ReadJsonKeysValues
{
    static void Main()
    {
        string json = File.ReadAllText("user.json");

        // Remove { } and split by comma
        string content = json.Trim('{', '}', '\n', ' ');
        string[] pairs = content.Split(',');

        Console.WriteLine("Keys and Values:");
        foreach (string pair in pairs)
        {
            string[] kv = pair.Split(':');
            string key = kv[0].Trim().Trim('"');
            string value = kv[1].Trim().Trim('"');
            Console.WriteLine($"Key: {key}, Value: {value}");
        }
    }
}
