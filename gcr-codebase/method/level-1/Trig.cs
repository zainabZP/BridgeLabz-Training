using System;
class Trig{
    public static void CalculateTrig(double aid){
        double air = aid * (Math.PI / 180);
        double sinValue = Math.Sin(air);
        double cosValue = Math.Cos(air);
        double tanValue = Math.Tan(air);
        Console.WriteLine("Sine({0}°) = {1}", aid, sinValue);
        Console.WriteLine("Cosine({0}°) = {1}", aid, cosValue);
        Console.WriteLine("Tangent({0}°) = {1}", aid, tanValue);
    }
    static void Main(){
        Console.Write("Enter an angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());
        CalculateTrig(angle);
    }
}
