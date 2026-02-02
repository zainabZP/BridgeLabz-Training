using System;
using System.IO;

class FilterJson
{
    static void Main()
    {
        string json = File.ReadAllText("users.json");
        string[] records = json.Trim('[', ']', '\n', ' ').Split(new string[] { "}," }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Users older than 25:");

        foreach (string record in records)
        {
            string r = record.Trim();
            if (!r.EndsWith("}")) r += "}";

            int ageIndex = r.IndexOf("\"Age\"");
            int colon = r.IndexOf(":", ageIndex);
            int end = r.IndexOf("}", ageIndex);
            string ageStr = r.Substring(colon + 1, end - colon - 1).Trim();
            int age = int.Parse(ageStr);

            if (age > 25)
            {
                int nameIndex = r.IndexOf("\"Name\"");
                int nameColon = r.IndexOf(":", nameIndex);
                int nameEnd = r.IndexOf(",", nameIndex);
                if (nameEnd == -1) nameEnd = r.IndexOf("}", nameIndex);
                string name = r.Substring(nameColon + 1, nameEnd - nameColon - 1).Trim().Trim('"');

                Console.WriteLine($"Name: {name}, Age: {age}");
            }
        }
    }
}
