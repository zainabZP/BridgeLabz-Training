using System;
class SpringSeason{
    static void Main(string[] args){
        // take month and year as input from user
        int m=int.Parse(Console.ReadLine());
        int d= int.Parse(Console.ReadLine());
        // check if month and day lies withing spring range
        if ((m==3&&day>=20)||(m==4)||(m==5)||(m==6&&day<=20)){
            Console.WriteLine("Its Spring Season");
        }
        else{
            Console.WriteLine("Not Spring Season");
        }
    }
}
