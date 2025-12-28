using System;

class MyNumberGuessGame
{
    static Random rand = new Random();

    static void Main()
    {
        int min = 1;
        int max = 100;
        bool isGuessed = false;

        Console.WriteLine("Think of a number between 1 and 100 and I will try to guess it!");

        while (!isGuessed)
        {
            int guess = MakeGuess(min, max);
            Console.WriteLine("My guess is: " + guess);
            Console.Write("Is it too High (H), too Low (L), or Correct (C)? ");
            char response = GetUserFeedback();

            if (response == 'C')
            {
                isGuessed = true;
                Console.WriteLine("Yay! I guessed it correctly!");
            }
            else if (response == 'H')
            {
                max = guess - 1;
            }
            else if (response == 'L')
            {
                min = guess + 1;
            }
        }
    }

    // Method to generate a random guess within the range
    static int MakeGuess(int min, int max)
    {
        return rand.Next(min, max + 1);
    }

    // Method to get feedback from the user
    static char GetUserFeedback()
    {
        return Char.ToUpper(Console.ReadLine()[0]);
    }
}
