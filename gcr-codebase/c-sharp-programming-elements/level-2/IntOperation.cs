using System;
class IntOperation{
    static void Main() {
        Console.Write("Enter value of x: ");
        int x= Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter value of z: ");
        int z = Convert.ToInt32(Console.ReadLine());
        int firstResult = (x+y*z);
        int secondResult = x*y+z;
        int third = (z+x/y);
        int fourth = (x%y+z);
        Console.WriteLine($"x+y*z = {firstResult}, x*y+z = {secondResult}, z+x/y = {third}, x%y+z = {fourth}");
    }
}