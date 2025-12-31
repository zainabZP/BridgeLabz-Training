using System;

class Mathematical
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Factorial is: " + Factorial(n));
        Console.WriteLine("Is prime? " + Prime(n));

        Console.WriteLine("Enter numbers to find GCD:");
        Console.Write("First number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("GCD is: " + GreatestCommonD(a, b));

        Console.WriteLine(n + "th Fibonacci number is: " + Fibonacci(n));
    }

    static long Factorial(int num)
    {
        if (num < 0)
        {
            Console.WriteLine("Factorial not defined for negative numbers.");
            return -1;
        }

        long fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact = fact * i;
        }
        return fact;
    }

    static bool Prime(int num)
    {
        if (num <= 1) return false;

        int divisorCount = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                divisorCount++;
            }
        }
        return divisorCount == 2;
    }

    static int GreatestCommonD(int x, int y)
    {
        int[] divX = new int[x];
        int[] divY = new int[y];
        int countX = 0, countY = 0;

        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0) divX[countX++] = i;
        }

        for (int i = 1; i <= y; i++)
        {
            if (y % i == 0) divY[countY++] = i;
        }

        int gcd = 1;
        for (int i = 0; i < countX; i++)
        {
            for (int j = 0; j < countY; j++)
            {
                if (divX[i] == divY[j])
                    gcd = divX[i];
            }
        }
        return gcd;
    }

    static long Fibonacci(int n)
    {
        if (n < 0)
        {
            Console.WriteLine("Fibonacci not defined for negative numbers.");
            return -1;
        }

        if (n == 0) return 0;
        if (n == 1) return 1;

        long first = 0, second = 1, result = 0;
        for (int i = 2; i <= n; i++)
        {
            result = first + second;
            first = second;
            second = result;
        }
        return result;
    }
}
