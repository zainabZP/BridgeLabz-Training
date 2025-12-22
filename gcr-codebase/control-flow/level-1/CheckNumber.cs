using System;
class CheckSign{
	
    static void Main(){
		
		// take a number as input from use
        int n=int.Parse(Console.ReadLine());
		
		// Conditions to check whether a number is >0, <0, or =0
        if (n>0)
            Console.WriteLine("positive");
        else if (n<0)
            Console.WriteLine("negative");
        else
            Console.WriteLine("zero");
    }
}
