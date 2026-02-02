using System;
using System.IO;

class ConvertJsonToXml
{
    static void Main()
    {
        string json = File.ReadAllText("user.json").Trim('{','}','\n',' ');
        string[] pairs = json.Split(',');

        Console.WriteLine("<User>");
        foreach (string pair in pairs)
        {
            string[] kv = pair.Split(':');
            string key = kv[0].Trim().Trim('"');
            string value = kv[1].Trim().Trim('"');
            Console.WriteLine($"  <{key}>{value}</{key}>");
        }
        Console.WriteLine("</User>");
    }
}
