using System;
using System.IO;

class User
{
    public string Name;
    public int Age;
}

class ListToJson
{
    static void Main()
    {
        User[] users = new User[]
        {
            new User { Name="Aman", Age=24 },
            new User { Name="Riya", Age=23 },
            new User { Name="Luna", Age=22 }
        };

        string json = "[\n";
        for (int i = 0; i < users.Length; i++)
        {
            json += "  {\n" +
                    "    \"Name\": \"" + users[i].Name + "\",\n" +
                    "    \"Age\": " + users[i].Age + "\n" +
                    "  }";
            if (i < users.Length - 1) json += ",";
            json += "\n";
        }
        json += "]";

        File.WriteAllText("users.json", json);
        Console.WriteLine("JSON array created!");
    }
}
