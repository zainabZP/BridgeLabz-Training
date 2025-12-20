using System;

class PercentageOfSam{
	static void Main(){
		// creating 3 double variables 'mathMarks', 'physicsMarks', 'chemistryMarks' and assign value '94', '95', '96'
		double mathMarks=94;
		double physicsMarks=95;
		double chemistryMarks=96;
		// calculating sam's percentage
		double percentage=(mathMarks+physicsMarks+chemistryMarks)/300;
		// printing sam's percentage
		Console.WriteLine(percentage*100);
	}
}
