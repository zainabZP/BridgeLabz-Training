using System;
using System.Reflection;

// Custom attribute
[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name) => Name = name;
}

// Apply attribute
[Author("Luna")]
class MyClass
{
    public void SayHi() => Console.WriteLine("Hi!");
}

class Program
{
    static void Main()
    {
        Type type = typeof(MyClass);
        var attr = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        if (attr != null)
            Console.WriteLine("Author: " + attr.Name);
    }
}
