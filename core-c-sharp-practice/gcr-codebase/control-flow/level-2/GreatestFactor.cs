using System;
class GreatestFactor{
	static void Main(){
		Console.WriteLine("enter number");
		int n=int.Parse(Console.ReadLine());
		int max=1;
		for(int i=1;i<n;i++){
			if(n%i==0)
				max=Math.Max(max,i);
		}
		Console.WriteLine("greatest factor of "+n+" is "+max);
	}
}