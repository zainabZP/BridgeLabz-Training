using System;
class PlayersHeightMean{
    static void Main(){
        double[] height=new double[11];
        double sum=0;
        // taking a number as an input
        Console.WriteLine("enter age of 11 players : ");
        for(int i=0;i<11;i++){
            height[i]=double.Parse(Console.ReadLine());
            sum=sum+height[i];
        }
        Console.WriteLine("mean of height of 11 football players = "+(sum/11.0));
    }
}
