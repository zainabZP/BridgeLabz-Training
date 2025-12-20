using System;
class RoundsByAthelets {
    public static void Main(string[] args) {
        Console.Write("Enter side1: ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side2: ");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side3: ");
        double third = Convert.ToDouble(Console.ReadLine());
        double perimeter =first+second+third;
        double distance =5000;
        double rounds =distance/perimeter;
        Console.WriteLine("rounds = "+ rounds);
    }
}