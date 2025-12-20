using System;

class ConvertHeight{
	static void Main(){
        double centimeter = Convert.ToDouble(Console.ReadLine());
        double inch = centimeter / 2.54;
        double feet = inch / 12.0;
        Console.WriteLine("height in cm = " + centimeter + " while in feet = " + feet + " and height in inch = " + inch );
	}
}