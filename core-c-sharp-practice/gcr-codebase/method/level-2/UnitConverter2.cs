using System;
class UnitConvert2{
    static void Main(){
        Console.WriteLine("1. Yard to Feet");
        Console.WriteLine("2. Feet to Yard");
        Console.WriteLine("3. Meter to Inch");
        Console.WriteLine("4. Inch to Meter");
        Console.WriteLine("5. Inch to Cm");

        int ch=int.Parse(Console.ReadLine());
        double v=double.Parse(Console.ReadLine());
        double r=0;

        if(ch==1){
            r=YardToFeet(v);
            Console.WriteLine(r);
        }
        else if(ch==2){
            r=FeetToYard(v);
            Console.WriteLine(r);
        }
        else if(ch==3){
            r=MeterToInch(v);
            Console.WriteLine(r);
        }
        else if(ch==4){
            r=InchToMeter(v);
            Console.WriteLine(r);
        }
        else if(ch==5){
            r=InchToCm(v);
            Console.WriteLine(r);
        }
        else{
            Console.WriteLine("Invalid");
        }
    }

    static double YardToFeet(double y){
        return y*3;
    }
    static double FeetToYard(double f){
        return f*0.333333;
    }
    static double MeterToInch(double m){
        return m*39.3701;
    }
    static double InchToMeter(double i){
        return i*0.0254;
    }
    static double InchToCm(double i){
        return i*2.54;
    }
}
