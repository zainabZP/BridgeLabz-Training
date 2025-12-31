using System;
class NumberReverse{
    static void Main(){
        // take number from user
        Console.WriteLine("enter number :");
        int n=int.Parse(Console.ReadLine());
        int rev=0;
        // reverse the number
        while(n>0){
            int temp=n%10;
            rev=rev*10+temp;
            n=n/10;
        }
        Console.WriteLine(rev);
    }
}
