using System;
class Euclidean{
    public static double Distance(double x1,double y1,double x2,double y2){
        double d=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
        return d;
    }
    public static double[] LineEquation(double x1,double y1,double x2,double y2){
        double m=(y2-y1)/(x2-x1);
        double b=y1-(m*x1);
        double[] arr={m,b};
        return arr;
    }
    static void Main(){
        Console.WriteLine("Enter x1, x2, y1, y2  : ");
        double x1=double.Parse(Console.ReadLine()!);
        double y1=double.Parse(Console.ReadLine()!);
        double x2=double.Parse(Console.ReadLine()!);
        double y2=double.Parse(Console.ReadLine()!);
        double d=Distance(x1,y1,x2,y2);
        Console.WriteLine("Euclidean distance = "+d);
        double[] a=LineEquation(x1,y1,x2,y2);
        Console.WriteLine("Equation of line: y = "+a[0]+" * x + "+a[1]);
    }
}
