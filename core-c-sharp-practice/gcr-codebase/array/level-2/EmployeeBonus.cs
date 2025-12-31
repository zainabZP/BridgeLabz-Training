using System;
class EmplyeeBonus{
    static void Main(){
        double[] s=new double[10];
        double[] y=new double[10];
        double[] b=new double[10];
        Console.WriteLine("enter salary of 10 employee : ");
        for(int i=0;i<10;i++){
            s[i]=double.Parse(Console.ReadLine());
        }
        Console.WriteLine("enter working years of 10 employee : ");
        for(int i=0;i<10;i++){
            y[i]=double.Parse(Console.ReadLine());
        }
        for(int i=0;i<10;i++){
            if(y[i]>5)
                b[i]=0.05*s[i];
            else
                b[i]=0.02*s[i];
        }
        for(int i=0;i<10;i++){
            Console.WriteLine(b[i]+ " old salary = "+s[i]+" new salary = "+(b[i]+s[i]));
        }
    }
}