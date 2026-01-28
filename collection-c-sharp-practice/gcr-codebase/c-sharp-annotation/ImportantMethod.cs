using System;
using System.Reflection;

// Step 1: Define the custom attribute
[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; set; } = "HIGH"; // default value
}

// Step 2: Create a class with some methods
public class MyClass
{
    [ImportantMethod(Level = "HIGH")]
    public void CriticalTask()
    {
        Console.WriteLine("Executing CriticalTask...");
    }

    [ImportantMethod(Level = "MEDIUM")]
    public void RegularTask()
    {
        Console.WriteLine("Executing RegularTask...");
    }

    public void NormalTask()
    {
        Console.WriteLine("Executing NormalTask...");
    }
}

// Step 3: Main program to find and display important methods
class Program
{
    static void Main()
    {
        Type type = typeof(MyClass);

        Console.WriteLine("Important methods in MyClass:");
        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
        {
            var attr = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attr != null)
            {
                Console.WriteLine($"Method: {method.Name}, Level: {attr.Level}");
            }
        }
    }
}
