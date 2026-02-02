using System;
using System.IO;

class ReadJson
{
    static void Main()
    {
        string json = File.ReadAllText("user.json");

        int nameStart = json.IndexOf("\"name\"");
        int emailStart = json.IndexOf("\"email\"");

        Console.WriteLine(json.Substring(nameStart, 20));
        Console.WriteLine(json.Substring(emailStart, 30));
    }
}
