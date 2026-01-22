using System;
using System.IO;

class UserInputToFile
{
    static void Main()
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("input.txt"))
            {
                Console.Write("Enter Name: ");
                sw.WriteLine(Console.ReadLine());

                Console.Write("Enter Age: ");
                sw.WriteLine(Console.ReadLine());

                Console.Write("Favorite Language: ");
                sw.WriteLine(Console.ReadLine());
            }

            Console.WriteLine("Data saved to input.txt");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
