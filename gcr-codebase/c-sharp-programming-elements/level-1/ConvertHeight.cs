using System;

class ConvertHeight{
	static void Main(){
		// taking height in cm as user input
        double centimeter = Convert.ToDouble(Console.ReadLine());
		// converting height to inches and then to feet
        double inch = centimeter / 2.54;
        double feet = inch / 12.0;
		// printing height after conversion
        Console.WriteLine("height in cm = " + centimeter + " while in feet = " + feet + " and height in inch = " + inch );
	}
}
