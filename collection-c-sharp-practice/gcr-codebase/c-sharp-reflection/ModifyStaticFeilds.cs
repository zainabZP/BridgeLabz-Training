using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OLD_KEY";

    public static void PrintKey()
    {
        Console.WriteLine("API_KEY = " + API_KEY);
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Configuration);

        // Access private static field
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);
        Console.WriteLine("Original API_KEY: " + field.GetValue(null));

        // Modify field
        field.SetValue(null, "NEW_KEY");
        Console.WriteLine("Modified API_KEY: " + field.GetValue(null));
    }
}
