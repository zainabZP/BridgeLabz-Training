using System;
using System.IO;

class ValidateEmailJson
{
    static void Main()
    {
        string json = File.ReadAllText("user.json");
        int emailIndex = json.IndexOf("\"email\"");
        if (emailIndex != -1)
        {
            int colon = json.IndexOf(":", emailIndex);
            int end = json.IndexOf(",", emailIndex);
            if (end == -1) end = json.IndexOf("}", emailIndex);
            string email = json.Substring(colon + 1, end - colon - 1).Trim().Trim('"');

            if (email.Contains("@") && email.Contains("."))
                Console.WriteLine($"Email '{email}' looks valid");
            else
                Console.WriteLine($"Email '{email}' is invalid");
        }
    }
}
