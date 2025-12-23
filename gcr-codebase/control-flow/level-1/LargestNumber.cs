using System;
class LargestOfThreeNumbers{
    static void Main(){
        string[] input = Console.ReadLine().Split();
        int n1=int.Parse(input[0]);
        int n2=int.Parse(input[1]);
        int n3=int.Parse(input[2]);
        if (n1>=n2&&n1>=n3)
            Console.WriteLine("First is largest");
        else if (n2>=n1&&n2>=n3)
            Console.WriteLine("Second is largest");
        else
            Console.WriteLine("Third is largest");
    }
}
