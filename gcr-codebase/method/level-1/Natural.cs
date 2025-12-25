using System;
class Add{
	static int Sum(int n){
		int sum=0;
		for(int i=1;i<=n;i++){
			sum=sum+i;
		}
		return sum;
		
	}
	static void Main(){
		int n=int.Parse(Console.ReadLine());
		int r=Sum(n);
			Console.WriteLine(r);
	}
}
	
	
