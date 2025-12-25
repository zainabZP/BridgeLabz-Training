using System;
class Leap{
    static void Main(){
        Console.Write("Enter year: ");
        int y=int.Parse(Console.ReadLine());

        bool r=Check(y);
        if(r) Console.WriteLine("Leap Year");
        else Console.WriteLine("Not a Leap Year");
    }

    static bool Check(int y){
        if(y<1582) return false;
        if((y%4==0 && y%100!=0) || y%400==0) return true;
        else return false;
    }
}
