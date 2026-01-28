using System;
using System.Collections.Generic;
using System.Reflection;

// Step 1: Define CacheResult attribute
[AttributeUsage(AttributeTargets.Method)]
public class CacheResultAttribute : Attribute { }

// Step 2: Class with expensive method
public class Calculator
{
    private Dictionary<int, int> cache = new Dictionary<int, int>();

    [CacheResult]
    public int Fibonacci(int n)
    {
        if (cache.ContainsKey(n))
            return cache[n];

        int result;
        if (n <= 1) result = n;
        else result = Fibonacci(n - 1) + Fibonacci(n - 2);

        cache[n] = result;
        return result;
    }
}

// Step 3: Main program
class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Type type = typeof(Calculator);
        MethodInfo method = type.GetMethod("Fibonacci");

        int[] testValues = { 10, 20, 30 };
        foreach (int n in testValues)
        {
            var attr = method.GetCustomAttribute<CacheResultAttribute>();
            if (attr != null)
            {
                int result = (int)method.Invoke(calc, new object[] { n });
                Console.WriteLine($"Fibonacci({n}) = {result}");
            }
        }
    }
}
