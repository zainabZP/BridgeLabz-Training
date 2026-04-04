using System;
using System.Reflection;

class Person
{
    private int age = 20;
}

class Program
{
    static void Main()
    {
        Person p = new Person();

        // Get type
        Type type = typeof(Person);

        // Access private field
        FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine("Original Age: " + field.GetValue(p));

        // Modify private field
        field.SetValue(p, 35);
        Console.WriteLine("Modified Age: " + field.GetValue(p));
    }
}
