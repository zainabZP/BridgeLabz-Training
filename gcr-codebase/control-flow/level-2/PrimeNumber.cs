using System;
class PrimeNumber{
	static void Main(){
		int p=int.Parse(Console.ReadLine());
		int f=0;
		for(int i=2;i<p;i++){
			if(p%i==0){
				Console.WriteLine("not a prime number");
				f=1;
				break;
			}
		}
		if(f!=1) Console.WriteLine("its a prime number");
	}
}