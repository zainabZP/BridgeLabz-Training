using System;
class TemperatureAnalyzer{
    public static void Main(){
        TemperatureAnalyzer obj=new TemperatureAnalyzer();
        double[,] temperature=new double[7,24];
        Console.WriteLine("enter temperatures for 7 days (24 hours for each)");
        for(int i=0;i<7;i++){
            Console.WriteLine("day "+(i+1));
            for(int j=0;j<24;j++){
                temperature[i,j]=double.Parse(Console.ReadLine());
            }
        }
        obj.FindHotAndColdDay(temperature);
        obj.AverageTemperaturePerDay(temperature);
    }
    public void FindHotAndColdDay(double[,] temperature){
        double max=temperature[0,0];
        double min=temperature[0,0];
        int hotDay=1,coldDay=1;
        for(int i=0;i<7;i++){
            for(int j=0;j<24;j++){
                if(max<temperature[i,j]){
                    max=temperature[i,j];
                    hotDay=i+1;
                }
                else if(min>temperature[i,j]){
                    min=temperature[i,j];
                    coldDay=i+1;
                }
            }
        }
        Console.WriteLine("hottest day = day "+hotDay);
        Console.WriteLine("coldest day = day "+coldDay);
    }
    public void AverageTemperaturePerDay(double[,] temperature){
        for(int i=0;i<7;i++){
            double sum=0;
            for(int j=0;j<24;j++){
                sum+=temperature[i,j];
            }
            Console.WriteLine("average temperature of day "+(i+1)+" = "+(sum/24.0));
        }
    }
}
