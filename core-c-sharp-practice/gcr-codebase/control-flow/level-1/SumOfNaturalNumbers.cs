using System;
class SumOfNaturalNumbers{
    static void Main(){
        // take a number as inpput from user -
        int n=int.Parse(Console.ReadLine());
        // calculate sum of first n natural no. using formula
            int formula=n*(n+1)/2;
            int sum=0;
            int i=1;
            // calculate sum of first n natural no. using loop
            while(i<=n){
                sum=sum+i;
                i++;
            }
            Console.WriteLine("Sum using formula = " +formula);
            Console.WriteLine("Sum using while loop = " +sum);
    }
}
