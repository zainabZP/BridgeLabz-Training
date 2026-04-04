using System;

class ValidateJson
{
    static void Main()
    {
        string json = "{ \"name\": \"Luna\", \"age\": 22 }";

        if (json.StartsWith("{") && json.EndsWith("}"))
        {
            Console.WriteLine("JSON format looks valid");
        }
        else
        {
            Console.WriteLine("Invalid JSON");
        }
    }
}
