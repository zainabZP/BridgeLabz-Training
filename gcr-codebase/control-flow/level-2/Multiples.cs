using System;
class Multiples{
	static void Main(){
		Console.WriteLine("enter number");
		int n=int.Parse(Console.ReadLine());
		for(int i=99;i>n;i--){
			if(i%n==0)
				Console.WriteLine(i); // print multiples of n
		}
	}
}