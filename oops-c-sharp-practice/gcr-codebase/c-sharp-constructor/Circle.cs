using System;

class CircleInfo
{
    public double radValue;

    // default constructor using chaining
    public CircleInfo() : this(2.5)
    {
        // radius initialized through another constructor
    }

    // parameterized constructor
    public CircleInfo(double radius)
    {
        radValue = radius;
    }

    static void Main(string[] args)
    {
        // object with default constructor
        CircleInfo firstCircle = new CircleInfo();

        // object with parameterized constructor
        CircleInfo secondCircle = new CircleInfo(5.0);

        Console.WriteLine("First Radius  : " + firstCircle.radValue);
        Console.WriteLine("Second Radius : " + secondCircle.radValue);
    }
}
