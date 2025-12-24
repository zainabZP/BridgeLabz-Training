using System;
class TimeZone{
    static void Main(){
        string t1=Console.ReadLine();
        string t2=Console.ReadLine();
        string t1s=t1.Substring(3, 2);
        string t2s=t2.Substring(3, 2);
        int m1 =int.Parse(t1s);
        int m2 =int.Parse(t2s);
        int diff =Math.Abs(m1-m2);
        int angle = diff * 6;
        Console.WriteLine(angle);
    }
}
