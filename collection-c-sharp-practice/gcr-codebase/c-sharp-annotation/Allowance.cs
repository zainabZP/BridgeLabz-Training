using System;
using System.Reflection;

// Attribute to mark role access
[AttributeUsage(AttributeTargets.Method)]
public class RoleAllowedAttribute : Attribute
{
    public string Role { get; }
    public RoleAllowedAttribute(string role) { Role = role; }
}

// Class with methods
public class AdminPanel
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser() => Console.WriteLine("User deleted!");

    public void ViewProfile() => Console.WriteLine("Profile viewed!");
}

// Main program
class Program
{
    static void Main()
    {
        string currentUserRole = "USER"; // Change to "ADMIN" to test
        AdminPanel panel = new AdminPanel();
        Type type = typeof(AdminPanel);

        // Only loop through declared methods (skip inherited ones like ToString)
        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            var attr = method.GetCustomAttribute<RoleAllowedAttribute>();
            
            if (attr != null && attr.Role != currentUserRole)
            {
                Console.WriteLine($"Access Denied to method {method.Name} for role {currentUserRole}");
            }
            else
            {
                // Check if method has parameters
                if (method.GetParameters().Length == 0)
                {
                    method.Invoke(panel, null);
                }
                else
                {
                    Console.WriteLine($"Skipping method {method.Name} because it requires parameters.");
                }
            }
        }
    }
}
