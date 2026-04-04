using System;

class LexicalTwist
{
    public static void CheckReverse(string s1, string s2)
    {
        if (s1.Contains(" "))
        {
            Console.WriteLine(s1 + " is an invalid word");
            return;
        }
        if (s2.Contains(" "))
        {
            Console.WriteLine(s2 + " is an invalid word");
            return;
        }

        char[] arr = s1.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        if (reversed.Equals(s2, StringComparison.OrdinalIgnoreCase))
        {

            reversed = reversed.ToLower();
            char[] res = reversed.ToCharArray();

            for (int i = 0; i < res.Length; i++)
            {
                if ("aeiou".Contains(res[i]))
                    res[i] = '@';
            }

            Console.WriteLine(new string(res));
        }
        else
        {

            string combined = (s1 + s2).ToUpper();

            int vowels = 0, consonants = 0;

            foreach (char c in combined)
            {
                if ("AEIOU".Contains(c)) vowels++;
                else if (c >= 'A' && c <= 'Z') consonants++;
            }

            string result = "";

            if (vowels > consonants)
            {
                foreach (char c in combined)
                {
                    if ("AEIOU".Contains(c) && !result.Contains(c) && result.Length < 2)
                        result += c;
                }
                Console.WriteLine(result);
            }
            else if (consonants > vowels)
            {
                foreach (char c in combined)
                {
                    if (!"AEIOU".Contains(c) && !result.Contains(c) &&
                        c >= 'A' && c <= 'Z' && result.Length < 2)
                        result += c;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Vowels and consonants are equal");
            }
        }
    }

    public static void Main()
    {
        Console.WriteLine("Enter the first word");
        string s1 = Console.ReadLine();

        Console.WriteLine("Enter the second word");
        string s2 = Console.ReadLine();

        CheckReverse(s1, s2);
    }
}
