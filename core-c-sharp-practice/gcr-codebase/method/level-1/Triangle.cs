using System;
class TriangleCalc{
	static int rounds(int x1,int x2,int x3){
		int p=x1+x2+x3;
		int d=5;
		int r=d/p;
		return r;
	}
	static void Main(){
		int x1=int.Parse(Console.ReadLine());
		int x2=int.Parse(Console.ReadLine());
		int x3=int.Parse(Console.ReadLine());
		int ro=rounds(x1,x2,x3);
		Console.WriteLine(ro);
	}
}
		
		
