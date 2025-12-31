using System;
class Triangle{
    public static bool Slope(double x1,double y1,double x2,double y2,double x3,double y3){
        double a=(y2-y1)/(x2-x1);
        double b=(y3-y2)/(x3-x2);
        double c=(y3-y1)/(x3-x1);
        if(a==b&&b==c) return true;
        else return false;
    }
    public static bool Area(double x1,double y1,double x2,double y2,double x3,double y3){
        double a=0.5*(x1*(y2-y3)+x2*(y3-y1)+x3*(y1-y2));
        if(a==0) return true;
        else return false;
    }
    static void Main(){
        Console.WriteLine("Enter x1, x2, y1, y2, x3, y3  : ");
        double x1=double.Parse(Console.ReadLine()!);
        double y1=double.Parse(Console.ReadLine()!);
        double x2=double.Parse(Console.ReadLine()!);
        double y2=double.Parse(Console.ReadLine()!);
        double x3=double.Parse(Console.ReadLine()!);
        double y3=double.Parse(Console.ReadLine()!);
        if(Slope(x1,y1,x2,y2,x3,y3)) Console.WriteLine("Points are collinear according to Slope Method");
        else Console.WriteLine("Points are not collinear according to Slope Method");
        if(Area(x1,y1,x2,y2,x3,y3)) Console.WriteLine("Points are collinear according to Area Method");
        else Console.WriteLine("Points are not collinear according to Area Method");
    }
}
