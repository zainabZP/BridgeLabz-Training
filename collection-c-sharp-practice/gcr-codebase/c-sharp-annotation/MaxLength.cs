using System;
using System.Reflection;

// Step 1: Define MaxLength attribute
[AttributeUsage(AttributeTargets.Field)]
public class MaxLengthAttribute : Attribute
{
    public int Value { get; }
    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

// Step 2: User class with field
public class User
{
    [MaxLength(5)]
    public string Username;

    public User(string username)
    {
        // Validation using Reflection
        FieldInfo field = typeof(User).GetField("Username");
        var attr = field.GetCustomAttribute<MaxLengthAttribute>();
        if (username.Length > attr.Value)
            throw new ArgumentException($"Username cannot exceed {attr.Value} characters.");
        Username = username;
    }
}

// Step 3: Main program
class Program
{
    static void Main()
    {
        try
        {
            User u1 = new User("Alice");
            Console.WriteLine("Username valid: " + u1.Username);

            User u2 = new User("TooLongName"); // This will throw exception
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
