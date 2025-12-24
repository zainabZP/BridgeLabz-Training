using System;
class SmallestAndTallest{
	static void Main(){
        // take age from user
        Console.WriteLine("enter age :");
		double[] age=new double[3];
        // take height from user
        Console.WriteLine("enter height :");
        double[] height=new double[3];
        for(int i=0;i<3;i++){
            age[i]=double.Parse(Console.ReadLine());
        }
        for(int i=0;i<3;i++){
            height[i]=double.Parse(Console.ReadLine());
        }
        // cal minimum age and max height
        double minAge=Math.Min(Math.Min(age[0],age[1]),age[2]);
        double maxHeight=Math.Max(Math.Max(height[0],height[1]),height[2]);
		if(age[0]==minAge) Console.WriteLine("Amar is smallest");
		if(age[1]==minAge) Console.WriteLine("Akbar is smallest");
		if(age[2]==minAge) Console.WriteLine("Anthhony is smallest");
		if(height[0]==maxHeight) Console.WriteLine("Amar is tallest");
		if(height[1]==maxHeight) Console.WriteLine("Akbar is tallest");
		if(height[2]==maxHeight) Console.WriteLine("Anthhony is tallest");
	}
}