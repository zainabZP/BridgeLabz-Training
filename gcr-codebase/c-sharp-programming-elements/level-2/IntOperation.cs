using System;
class IntOperation{
    static void Main() {
        // take 3 integers as input from user
        Console.Write("Enter value of x: ");
        int x= Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of z: ");
        int z = Convert.ToInt32(Console.ReadLine());
        // performing diffetent operations on input numbers
        int firstResult = (x+y*z);
        int secondResult = x*y+z;
        int third = (z+x/y);
        int fourth = (x%y+z);
        // printing result of varius operations
        Console.WriteLine($"x+y*z = {firstResult}, x*y+z = {secondResult}, z+x/y = {third}, x%y+z = {fourth}");
    }
}
