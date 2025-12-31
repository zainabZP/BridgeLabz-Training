using System;
class AllFactors{
	static void Main(){
		Console.WriteLine("enter number");
		int n=int.Parse(Console.ReadLine());
		for(int i=1;i<=n;i++){
			if(n%i==0)
				Console.WriteLine(i); // print factors
		}
	}
}