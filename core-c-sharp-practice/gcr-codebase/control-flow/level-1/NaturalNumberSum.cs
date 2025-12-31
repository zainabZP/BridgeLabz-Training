using System;
class SumOfNaturalNumbers{
    static void Main(){
        // take a number asinput from user 
        int n=int.Parse(Console.ReadLine());
        if (n>=1){
            // calculate sum of first n natural number
            int sum=n*(n+1)/2;
            Console.WriteLine("sum of " +n+" natural numbers is "+sum);
        }
        else{
            Console.WriteLine("The number is not a natural number");
        }
    }
}
