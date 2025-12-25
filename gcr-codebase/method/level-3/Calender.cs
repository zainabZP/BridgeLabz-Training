using System;
class Calendar{
    public static string Month(int n){
        string[] arr={"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
        return arr[n-1];
    }
    public static bool LeapYear(int n){
        if((n%4==0&&n%100!=0)||n%400==0) return true;
        else return false;
    }
    public static int Days(int m,int y){
        bool ly=LeapYear(y);
        if(ly&&m==2) return 29;
        if(!ly&&m==2) return 28;
        else if((m<=7&&m%2!=0)||(m>7&&m%2==0)) return 31;
        else return 30;
    }

    public static int FirstDay(int m,int y){
        int d=1;
        int y0=y-(14-m)/12;
        int x=y0+y0/4-y0/100+y0/400;
        int m0=m+12*((14-m)/12)-2;
        int d0=(d+x+(31*m0)/12)%7;
        return d0;
    }
    static void Main(){
        Console.WriteLine("enter month : ");
        int m=int.Parse(Console.ReadLine());
        Console.WriteLine("enter year : ");
        int y=int.Parse(Console.ReadLine());
        int days=Days(m,y);
        int start=FirstDay(m,y);
        Console.WriteLine(Month(m)+" "+y);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
        for(int i=0;i<start;i++){                                         // ✅ added indentation for first day
            Console.Write("    ");                                         // ✅ print spaces before first date
        }
        for(int i=1;i<=days;i++){
            Console.Write(i+"    ");
            if((i+start)%7==0) Console.WriteLine();
        }
        Console.WriteLine();
        if(LeapYear(y)) Console.WriteLine("its lear year");
        Console.WriteLine("days in month= "+days);
    }
}
