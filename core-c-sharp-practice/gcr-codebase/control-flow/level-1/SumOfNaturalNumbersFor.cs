using System;
class SumOfNaturalNumbersFor{
    static void Main(){
        // take a number as input from user
        int n=int.Parse(Console.ReadLine());
        // cal sum of first n natural no., first using formula then using loop
        int sum=0;
        for (int i=1;i<=n;i++){
            sum=sum+i;
        }
        // print sum
        Console.WriteLine("Sum using for loop = "+sum);
    }
}
