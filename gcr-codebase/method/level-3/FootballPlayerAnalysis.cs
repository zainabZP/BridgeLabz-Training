using System;
class FootballPlayerAnalysis{
    public static void mean(double[] height){
        double sum=0;
        for(int i=0;i<11;i++){
            sum=sum+height[i];
        }
        Console.WriteLine("mean of height of 11 football players = "+(sum/11.0));
    }
    public static void shortest(double[] height){
        double min=100000;int s=1;
        for(int i=0;i<height.Length;i++){
            if(min>height[i]){
                min =height[i];
                s=i;
            }
        }
        Console.WriteLine((s+1)+" is the shortest person with height = "+min);
    }
    public static void tallest(double[] height){
        double max=0;int tall=1;
        for(int i=0;i<height.Length;i++){
            if(max<height[i]){
                max =height[i];
                tall=i;
            }
        }
        Console.WriteLine((tall+1)+" is the tallest person with height ="+max);
    }
    static void Main(){
        double[] height=new double[11];
        // taking a number as an input
        Console.WriteLine("enter height of 11 players in feet: ");
        for(int i=0;i<11;i++)
        height[i]=double.Parse(Console.ReadLine());
        mean(height);
        shortest(height);
        tallest(height);
        
    }
}
