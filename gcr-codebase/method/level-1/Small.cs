using System;
class Small{
	static void Check(int n1, int n2, int n3,out int small,out int large){
		small=n1;
		large=n1;                  
		if(n2<small) small=n2;    
		if(n3<small) small=n3;     
		if(n2>large) large=n2;    
		if(n3>large) large=n3;  
	}
	static void Main()
	{
		int n1=int.Parse(Console.ReadLine());
		int n2=int.Parse(Console.ReadLine());
		int n3=int.Parse(Console.ReadLine());
		int small;
		int large;
		Check(n1,n2,n3,out small,out large);
		Console.WriteLine(small);
		Console.WriteLine(large);
	}
}
