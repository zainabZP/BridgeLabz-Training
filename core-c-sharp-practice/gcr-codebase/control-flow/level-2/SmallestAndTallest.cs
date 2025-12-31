using System;
class SmallestAndTallest{
	static void Main(){
		Console.WriteLine("enter age1");
		int a1=int.Parse(Console.ReadLine());
		Console.WriteLine("enter age2");
		int a2=int.Parse(Console.ReadLine());
		Console.WriteLine("enter age3");
		int a3=int.Parse(Console.ReadLine());
		Console.WriteLine("enter height1 in m");
		double h1=double.Parse(Console.ReadLine());
		Console.WriteLine("enter height2 in m");
		double h2=double.Parse(Console.ReadLine());
		Console.WriteLine("enter height3 in m");
		double h3=double.Parse(Console.ReadLine());
		int minAge=Math.Min(Math.Min(a1,a2),a3);
		if(a1==minAge) Console.WriteLine("Amar is smallest");
		if(a2==minAge) Console.WriteLine("Akbar is smallest");
		if(a3==minAge) Console.WriteLine("Anthhony is smallest");
		double maxHeight=Math.Max(Math.Max(h1,h2),h3);
		if(h1==maxHeight) Console.WriteLine("Amar is tallest");
		if(h2==maxHeight) Console.WriteLine("Akbar is tallest");
		if(h3==maxHeight) Console.WriteLine("Anthhony is tallest");
	}
}