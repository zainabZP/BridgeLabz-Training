using System;
class CountDigits{
    static void Main(){
		// take an integer as input
        Console.Write("Enter a number: ");
        int n=int.Parse(Console.ReadLine());
		// initialize count with 0
        int c=0;
        while (n!=0){
            n=n/10; // remove last digit
            c++;
        }
        Console.WriteLine("Number of digits = " +c);
    }
}
