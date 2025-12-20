using System;
class Operations {
    public static void Main() {
        Console.Write("Enter value of x: ");
        double x=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the  value of y: ");
        double y=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter value of z: ");
        double z=Convert.ToDouble(Console.ReadLine());
        double firstResult = x + y * z;
        double secondResult = x*y+z;
        double thirdResult= x+z/y;
		double fourthResult =x%y+z;
        Console.WriteLine($"result of Double Operations are {firstResult}, {secondResult}, {thirdResult}, {fourthResult}");
    }
}