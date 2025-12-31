using System;
class UnitConvert{
    static void Main(){
        Console.WriteLine("1. Km to Miles");
        Console.WriteLine("2. Miles to Km");
        Console.WriteLine("3. Meter to Feet");
        Console.WriteLine("4. Feet to Meter");

        int ch=int.Parse(Console.ReadLine());
        double v=double.Parse(Console.ReadLine());
        double r=0;

        if(ch==1){
            r=KmToMiles(v);
            Console.WriteLine(r);
        }
        else if(ch==2){
            r=MilesToKm(v);
            Console.WriteLine(r);
        }
        else if(ch==3){
            r=MeterToFeet(v);
            Console.WriteLine(r);
        }
        else if(ch==4){
            r=FeetToMeter(v);
            Console.WriteLine(r);
        }
        else{
            Console.WriteLine("Invalid");
        }
    }

    static double KmToMiles(double k){
        return k*0.621371;
    }
    static double MilesToKm(double m){
        return m*1.60934;
    }
    static double MeterToFeet(double m){
        return m*3.28084;
    }
    static double FeetToMeter(double f){
        return f*0.3048;
    }
}
