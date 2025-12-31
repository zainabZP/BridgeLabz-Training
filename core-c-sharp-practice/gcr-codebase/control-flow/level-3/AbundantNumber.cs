using System;
class CheckAbundantNumber{
    static void Main(){
        Console.Write("Enter number: ");
		// take a number as input from user
        int n=int.Parse(Console.ReadLine());
        int sum=0;
		// find divisors of the entered number and add them to sum
        for (int i=1;i<n;i++){
            if (n%i==0)
                sum=sum+i;
        }
		// check if sum is greater than number
        if (sum>n)
            Console.WriteLine("Abundant Number");
        else
            Console.WriteLine("Not an Abundant Number");
    }
}
