using System;

class AreaOfTriangle{

    static void Main(){
        double baseInInch = Convert.ToDouble(Console.ReadLine());
        double heightInInch = Convert.ToDouble(Console.ReadLine());
        double areaInSquareInch = 0.5 * baseInInch * heightInInch;
        double areaInSquareCentimeter = areaInSquareInch * 2.54 * 2.54;
		Console.WriteLine("Area of Triangle = " + areaInSquareInch + " square inch ");
		Console.WriteLine("Area of Triangle = " + areaInSquareCentimeter + "square centimeter" );
	}
}