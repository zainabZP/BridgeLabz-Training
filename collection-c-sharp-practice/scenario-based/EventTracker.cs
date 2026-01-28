using System;
using System.Reflection;

// Audit annotation
[AttributeUsage(AttributeTargets.Method)]
class AuditTrailAttribute : Attribute
{
    public string Action;

    public AuditTrailAttribute(string action)
    {
        Action = action;
    }
}

// Service class
class UserService
{
    [AuditTrail("User Login")]
    public void Login()
    {

    }
    [AuditTrail("File Upload")]
    public void Upload()
    {
    }

    public void ViewProfile()
    {
        // no audit needed
    }
}

// Main class
class EventTracker
{
    static void Main()
    {
        Type t = typeof(UserService);

        MethodInfo[] methods = t.GetMethods(
            BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly
        );

        Console.WriteLine("Audit Logs\n");

        foreach (MethodInfo m in methods)
        {
            AuditTrailAttribute audit =
                m.GetCustomAttribute<AuditTrailAttribute>();

            if (audit != null)
            {
                string json =
                    "{ \"Method\": \"" + m.Name + "\", " +
                    "\"Action\": \"" + audit.Action + "\", " +
                    "\"Time\": \"" + DateTime.Now + "\" }";

                Console.WriteLine(json);
            }
        }
    }
}
