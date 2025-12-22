using System;
class FactorialUsingForLoop{
    static void Main(){	
		// take a number as input from user
        int n=int.Parse(Console.ReadLine());
		// if number is >1 find its factorial
        if (n>=1){	
			// calculating factorial using for loop
            int fac = 1;
            for (int i = 1; i <= number; i++)
            {
                fac = fac * i;
            }
            Console.WriteLine("Factorial = " + fac);
        }
		// else ask user to enter positive number
        else{
            Console.WriteLine("enter a positive integer");
        }
    }
}
