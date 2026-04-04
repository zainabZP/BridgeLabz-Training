using System;
using System.IO;

class ManualParseAndFilterJson
{
    static void Main()
    {
        string json = File.ReadAllText("students.json");

        // Remove [ ] and split objects by "},"
        string[] records = json.Trim('[', ']', '\n', ' ', '\r')
                               .Split(new string[] { "}," }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Students with Age > 22:");

        foreach (string record in records)
        {
            // Make sure each object ends with '}'
            string r = record.Trim();
            if (!r.EndsWith("}")) r += "}";

            // --- Extract Age ---
            int age = -1;
            int ageIndex = r.IndexOf("\"Age\"");
            if (ageIndex != -1)
            {
                int colonIndex = r.IndexOf(":", ageIndex);
                int commaIndex = r.IndexOf(",", ageIndex);
                if (commaIndex == -1) commaIndex = r.IndexOf("}", ageIndex);

                string ageStr = r.Substring(colonIndex + 1, commaIndex - colonIndex - 1).Trim();
                if (int.TryParse(ageStr, out int parsedAge))
                    age = parsedAge;
            }

            // Only process if age was found
            if (age > 22)
            {
                // --- Extract Name ---
                string name = "";
                int nameIndex = r.IndexOf("\"Name\"");
                if (nameIndex != -1)
                {
                    int nameColon = r.IndexOf(":", nameIndex);
                    int nameEnd = r.IndexOf(",", nameIndex);
                    if (nameEnd == -1) nameEnd = r.IndexOf("}", nameIndex);

                    name = r.Substring(nameColon + 1, nameEnd - nameColon - 1)
                            .Trim().Trim('"');
                }

                Console.WriteLine($"Name: {name}, Age: {age}");
            }
        }
    }
}
