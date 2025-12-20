using System;

class DivideChocolates{
    static void Main(){
        Console.Write("Enter Total Chocolates and number of Children : ");
        string[] inp = Console.ReadLine().Split();
        int chocolates = int.Parse(inp[0]);
        int children = int.Parse(inp[1]);
        int chocolatesForEachChild = chocolates/children;
        int chocolatesLeftUndivided = chocolates%children;
        Console.WriteLine("Chocolates per child = " + chocolatesForEachChild +" and the number chocolates left undivided = " + chocolatesLeftUndivided);
    }
}
