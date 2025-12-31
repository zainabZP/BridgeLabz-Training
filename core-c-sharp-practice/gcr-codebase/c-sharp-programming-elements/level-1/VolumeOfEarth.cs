using System;

class VolumeOfEarth
{
    static void Main()
    {
		// create double varible 'earthRadius' and assign value 6378
        double earthRadius = 6378;
        double constant=4.0/3.0;
		// calculating volume of earth
		double volume=constant*3.14*earthRadius*earthRadius;
		// printing volume of earth
		Console.WriteLine(volume);
    }
}
