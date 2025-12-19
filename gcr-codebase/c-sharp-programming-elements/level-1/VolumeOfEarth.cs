using System;

class VolumeOfEarth
{
    static void Main()
    {
        double earthRadius = 6378;
        double constant=4.0/3.0;
		double volume=constant*3.14*earthRadius*earthRadius;
		Console.WriteLine(volume);
    }
}
