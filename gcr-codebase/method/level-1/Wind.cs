using System;
class Windss{
	public static double CalculateChill(double tem, double wspeed){
		double wc = 35.74 + 0.6215 * tem + (0.4275 * tem - 35.75) * Math.Pow(wspeed, 0.16);
		return wc;
	}
	static void Main(){
		double tem = double.Parse(Console.ReadLine());
		double wspeed = double.Parse(Console.ReadLine());
		double r=CalculateChill(tem, wspeed);
		Console.WriteLine(r);
	}
}