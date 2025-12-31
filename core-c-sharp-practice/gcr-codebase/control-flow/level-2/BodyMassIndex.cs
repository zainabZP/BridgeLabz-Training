using System;
class BodyMassIndex{
	static void Main(){
		Console.WriteLine("enter weight in kg");
		double w=double.Parse(Console.ReadLine()); // take weight input in kg
		Console.WriteLine("enter height in m");
		double h=double.Parse(Console.ReadLine()); // take height input in m
		double bmi=(w)/(h*h); //BMI = weight / (height * height);
		Console.WriteLine("bmi="+bmi);
		if(bmi<=18.4) Console.WriteLine("underweight");
		else if(bmi>=18.5&&bmi<=24.9) Console.WriteLine("normal");
		else if(bmi>=25.0&&bmi<=39.9) Console.WriteLine("overweight");
		else Console.WriteLine("obese");
	}
}