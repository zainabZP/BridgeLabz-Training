using System;
class Operations {
    public static void Main() {
		// taking three numbers of double type as input from user
        Console.Write("Enter value of x: ");
        double x=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the  value of y: ");
        double y=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter value of z: ");
        double z=Convert.ToDouble(Console.ReadLine());
		// performing different operations on input numbers
        double firstResult = x + y * z;
        double secondResult = x*y+z;
        double thirdResult= x+z/y;
		double fourthResult =x%y+z;
		// printing calculated result of different operations
        Console.WriteLine($"result of Double Operations are {firstResult}, {secondResult}, {thirdResult}, {fourthResult}");
    }
}
