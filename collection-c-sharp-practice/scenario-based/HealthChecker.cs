using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class PublicAPIAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Method)]
public class RequiresAuthAttribute : Attribute
{
}

public class LabTestController
{
    [PublicAPI]
    public void GetAllTests()
    {
    }

    [RequiresAuth]
    public void AddTest()
    {
    }

    public void DeleteTest()
    {
    }
}

class HealthCheckPro
{
    static void Main()
    {
        Type type = typeof(LabTestController);

        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly
        );

        Console.WriteLine("API Documentation\n");

        foreach (MethodInfo method in methods)
        {
            Console.WriteLine("Method: " + method.Name);

            if (method.GetCustomAttribute<PublicAPIAttribute>() != null)
            {
                Console.WriteLine("Type: Public API");
            }
            else if (method.GetCustomAttribute<RequiresAuthAttribute>() != null)
            {
                Console.WriteLine("Type: Requires Authentication");
            }
            else
            {
                Console.WriteLine("WARNING: Annotation missing");
            }

            Console.WriteLine();
        }
    }
}
