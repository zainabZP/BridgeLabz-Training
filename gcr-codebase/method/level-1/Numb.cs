using System;
class Number{
	static int Product(int n){
		if(n>0) return 1;
		else if(n<1) return -1;
		else return 0;
	}
	static void Main(){
	int n=int.Parse(Console.ReadLine());
	int r=Product(n);
	if(r==1) Console.WriteLine("positive");
	else if(r==0) Console.WriteLine("negative");
	else Console.WriteLine("zero");
	}
}