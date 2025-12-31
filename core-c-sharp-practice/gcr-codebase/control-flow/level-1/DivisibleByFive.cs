using System;
class CheckDivisibilityByFive{
    static void Main(){	
		// take a number as input from user
        int n=int.Parse(Console.ReadLine());
		// check if the number is divible by 5 and store result in variable r
        if(n%5==0)
        	Console.WriteLine("number is divisible by 5");
		else
			Console.WriteLine("number is not divisible by 5");
    }
}
