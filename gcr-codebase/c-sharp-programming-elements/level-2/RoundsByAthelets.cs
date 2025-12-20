using System;
class RoundsByAthelets {
    public static void Main(string[] args) {
        // taking 3 sides length as input from user
        Console.Write("Enter side1: ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side2: ");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side3: ");
        double third = Convert.ToDouble(Console.ReadLine());
        // calculating perimeter
        double perimeter =first+second+third;
        // distance to be covered
        double distance =5000;
        // calculating number of rounds completed
        double rounds =distance/perimeter;
        // printing calculated rounds
        Console.WriteLine("rounds = "+ rounds);
    }
}
