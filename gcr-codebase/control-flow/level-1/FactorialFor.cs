using System;
class FactorialUsingForLoop{
    static void Main(){	
		// take a number as input from user
        int n=int.Parse(Console.ReadLine());
		// calculating factorial using for loop
		int fac=1;
		for (int i=1;i<=number;i++){
			fac=fac*i;
		}
		Console.WriteLine("Factorial = " +fac);
    }
}
