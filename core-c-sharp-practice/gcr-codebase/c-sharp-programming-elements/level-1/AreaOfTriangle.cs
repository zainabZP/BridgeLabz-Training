using System;

class AreaOfTriangle{

    static void Main(){
        double baseInInch = Convert.ToDouble(Console.ReadLine());  // taking base as input in inches
        double heightInInch = Convert.ToDouble(Console.ReadLine()); // taking height as input in inches
        double areaInSquareInch = 0.5 * baseInInch * heightInInch; // calculating area of triangle in inches
        double areaInSquareCentimeter = areaInSquareInch * 2.54 * 2.54; // converting calculated area in centimeters
		// printing area in inches and in cm.
		Console.WriteLine("Area of Triangle = " + areaInSquareInch + " square inch ");
		Console.WriteLine("Area of Triangle = " + areaInSquareCentimeter + "square centimeter" );
	}
}
