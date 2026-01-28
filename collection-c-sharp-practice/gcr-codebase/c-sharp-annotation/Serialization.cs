using System;
using System.Reflection;
using System.Text;

// Step 1: Define JsonField attribute
[AttributeUsage(AttributeTargets.Field)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; set; }
}

// Step 2: User class with fields
public class User
{
    [JsonField(Name = "user_name")]
    public string Username;

    [JsonField(Name = "user_age")]
    public int Age;

    public User(string username, int age)
    {
        Username = username;
        Age = age;
    }
}

// Step 3: Convert object to JSON string using Reflection
class Program
{
    static void Main()
    {
        User u = new User("Alice", 25);
        Type type = typeof(User);

        StringBuilder json = new StringBuilder();
        json.Append("{ ");
        foreach (FieldInfo field in type.GetFields())
        {
            var attr = field.GetCustomAttribute<JsonFieldAttribute>();
            if (attr != null)
            {
                json.Append($"\"{attr.Name}\": \"{field.GetValue(u)}\", ");
            }
        }
        json.Length -= 2; // remove last comma
        json.Append(" }");

        Console.WriteLine("JSON: " + json);
    }
}
