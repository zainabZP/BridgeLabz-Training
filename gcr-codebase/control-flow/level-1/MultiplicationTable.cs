using System;
class MultiplicationOfTable{
    static void Main(){
        // take a number as input from user
        int n=int.Parse(Console.ReadLine());
        // calculate and print its multiple fron 6 to 9
        for (int i=6;i<=9;i++){
            Console.WriteLine(n+" * "+i+" = "+(n*i));
        }
    }
}
