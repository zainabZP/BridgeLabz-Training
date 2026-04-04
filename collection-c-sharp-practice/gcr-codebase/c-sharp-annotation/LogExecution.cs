using System;
using System.Diagnostics;
using System.Reflection;

// Step 1: Define attribute
[AttributeUsage(AttributeTargets.Method)]
public class LogExecutionTimeAttribute : Attribute { }

// Step 2: Class with methods
public class Calculator
{
    [LogExecutionTime]
    public void AddNumbers()
    {
        int sum = 0;
        for (int i = 0; i < 1000000; i++)
            sum += i;
    }

    [LogExecutionTime]
    public void MultiplyNumbers()
    {
        int result = 1;
        for (int i = 1; i <= 10000; i++)
            result *= i % 10 + 1;
    }
}

// Step 3: Main program
class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Type type = typeof(Calculator);

        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
        {
            var attr = method.GetCustomAttribute<LogExecutionTimeAttribute>();
            if (attr != null)
            {
                Stopwatch sw = Stopwatch.StartNew();
                method.Invoke(calc, null);
                sw.Stop();
                Console.WriteLine($"Method {method.Name} executed in {sw.ElapsedMilliseconds} ms");
            }
        }
    }
}
