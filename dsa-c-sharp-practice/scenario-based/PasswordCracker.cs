using System;

class PasswordCracker
{
    static string password = "ab";
    static char[] chars = { 'a', 'b', 'c' };
    static bool found = false;

    static void Main()
    {
        Console.WriteLine("Trying to crack password...");
        Crack("", 2);

        Console.WriteLine("Time Complexity: O(k^n)");
        Console.WriteLine("Space Complexity: O(n)");
    }

    static void Crack(string current, int length)
    {
        if (found)
            return;

        if (current.Length == length)
        {
            Console.WriteLine("Trying: " + current);

            if (current == password)
            {
                Console.WriteLine("Password Found: " + current);
                found = true;
            }
            return;
        }

        for (int i = 0; i < chars.Length; i++)
        {
            Crack(current + chars[i], length);
        }
    }
}
