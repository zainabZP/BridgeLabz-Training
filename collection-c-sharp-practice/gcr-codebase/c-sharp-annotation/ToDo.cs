using System;
using System.Reflection;

// Step 1: Define Todo attribute
[AttributeUsage(AttributeTargets.Method)]
public class TodoAttribute : Attribute
{
    public string Task { get; set; }
    public string AssignedTo { get; set; }
    public string Priority { get; set; } = "MEDIUM"; // default

    public TodoAttribute(string task, string assignedTo)
    {
        Task = task;
        AssignedTo = assignedTo;
    }
}

// Step 2: Class with methods having Todo attribute
public class Project
{
    [Todo("Implement login feature", "Alice", Priority = "HIGH")]
    public void Login() { }

    [Todo("Add report generation", "Bob")]
    public void GenerateReport() { }

    public void CompletedFeature() { }
}

// Step 3: Main program to list pending tasks
class Program
{
    static void Main()
    {
        Type type = typeof(Project);
        Console.WriteLine("Pending Tasks:");
        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
        {
            var todoAttr = method.GetCustomAttribute<TodoAttribute>();
            if (todoAttr != null)
            {
                Console.WriteLine($"Method: {method.Name}, Task: {todoAttr.Task}, AssignedTo: {todoAttr.AssignedTo}, Priority: {todoAttr.Priority}");
            }
        }
    }
}
