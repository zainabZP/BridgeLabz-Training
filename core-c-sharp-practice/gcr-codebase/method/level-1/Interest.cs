using System;
 class CalculateInterest{
	 static double simple(double p,double r,double t){
		 double si=((p*r*t)/100);
		 return si;
	 }
	 static void Main(){
		 int p=int.Parse(Console.ReadLine());
		 int r=int.Parse(Console.ReadLine());
		 int t=int.Parse(Console.ReadLine());
		 double r=simple(p,r,t);
		 Console.WriteLine(r);
	 }
 }
		 
		 