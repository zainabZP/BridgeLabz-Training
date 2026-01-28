using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.Write("Enter full class name (e.g., System.String): ");
        string className = Console.ReadLine();

        // Load the type using Reflection
        Type type = Type.GetType(className);
        if (type == null)
        {
            Console.WriteLine("Class not found!");
            return;
        }

        Console.WriteLine($"\nClass: {type.Name}");

        // Display Methods
        Console.WriteLine("\nMethods:");
        MethodInfo[] methods = type.GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }

        // Display Fields
        Console.WriteLine("\nFields:");
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (var field in fields)
        {
            Console.WriteLine(field.Name);
        }

        // Display Constructors
        Console.WriteLine("\nConstructors:");
        ConstructorInfo[] constructors = type.GetConstructors();
        foreach (var ctor in constructors)
        {
            Console.WriteLine(ctor.ToString());
        }
    }
}
