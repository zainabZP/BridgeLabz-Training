using System;
class Quadratic{
    static void Main(){
        Console.Write("Enter a: ");
        double a=double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b=double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c=double.Parse(Console.ReadLine());

        double[] r=Roots(a,b,c);

        if(r.Length==0){
            Console.WriteLine("No real roots");
        }
        else{
            for(int i=0;i<r.Length;i++){
                Console.WriteLine("Root = "+r[i]);
            }
        }
    }

    static double[] Roots(double a,double b,double c){
        double d=b*b-4*a*c;

        if(d>0){
            double r1=(-b+Math.Sqrt(d))/(2*a);
            double r2=(-b-Math.Sqrt(d))/(2*a);
            double[] arr={r1,r2};
            return arr;
        }
        else if(d==0){
            double r=-b/(2*a);
            double[] arr={r};
            return arr;
        }
        else{
            double[] arr=new double[0];
            return arr;
        }
    }
}
