using System;
using System.IO;

class StudentsListToJson
{
    static void Main()
    {
        // List of students
        string[] students = { "Aman", "Riya", "Luna" };

        // Start JSON array
        string json = "[\n";

        for (int i = 0; i < students.Length; i++)
        {
            json += "  \"" + students[i] + "\"";
            if (i < students.Length - 1)
                json += ",";
            json += "\n";
        }

        json += "]";

        // Write JSON to file
        File.WriteAllText("students.json", json);

        Console.WriteLine("JSON file created successfully!");
    }
}
