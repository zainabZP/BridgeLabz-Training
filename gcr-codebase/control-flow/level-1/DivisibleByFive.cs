using System;
class CheckDivisibilityByFive{
    static void Main(){	
		// take a number as input from user
        int n =int.Parse(Console.ReadLine());
		// check if the number is divible by 5 and store result in variable r
        bool r =n%5==0;
		// print result
        Console.WriteLine("Is number "+n+" divisible by 5? "+r);
    }
}
