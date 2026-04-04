using System;

class CircleDetails
{
    // stores radius value
    public double rad;

    // method to find and print results
    public void printResult()
    {
        double areaValue = Math.PI * rad * rad;
        double circleLength = 2 * Math.PI * rad;

        Console.WriteLine("Area of circle : " + areaValue);
        Console.WriteLine("Circumference : " + circleLength);
    }

    static void Main(string[] args)
    {
        // object declaration
        CircleDetails obj = new CircleDetails();

        // assigning radius
        obj.rad = 5.0;

        // method call
        obj.printResult();
    }
}
