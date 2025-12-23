using System;
class ArmstrongNumber{
    static void Main(){
        Console.Write("Enter a number: ");
        int n=int.Parse(Console.ReadLine());
        int temp=n;
        int sum=0;
        // loop until number becomes 0
        while (n!=0){
            int t=n%10; // get last digit
            int cube=t*t*t;
            sum=sum+cube; 
            n=n/10; // remove last digit
        }
        if (sum==temp)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
