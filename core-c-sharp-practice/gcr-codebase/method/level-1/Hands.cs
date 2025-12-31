using System;
class Hand{
	static int student(int n){
		int x=(n*(n-1))/2;
		return x;
	}
	static void Main(){
		int n=int.Parse(Console.ReadLine());
		int y=student(n);
		Console.WriteLine(y);
	}
}