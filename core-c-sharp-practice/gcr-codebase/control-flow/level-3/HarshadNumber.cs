using System;
class CheckHarshadNumber{
    static void Main(){
		// take a number as input from user 
        Console.Write("Enter number: ");
        int n=int.Parse(Console.ReadLine());
        int ogNumber=n;
        int sum=0;
		// find and add its digits
        while (n!=0){
			int t=n%10;
            sum=sum+t;// add digits
            n=n/10;
        }
		// check if original number is divisible by sum of its digit
        if (ogNumber%sum==0)
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("Not a Harshad Number");
    }
}
