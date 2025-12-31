using System;
class Season{
	static bool Check(int m,int d){
	if(m>=3&&m<=3&d>=20&&d<=20) return true;
	else return false;
	}
	static void Main(){
		int m=int.Parse(Console.ReadLine());
		int d=int.Parse(Console.ReadLine());
		bool res=Check(m,d);
		if(res==true) Console.WriteLine("Its a Spring Season");
		else Console.WriteLine("Not a Spring Season");
	}
}
		
	
