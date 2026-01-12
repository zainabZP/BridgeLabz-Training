using System;
class WoodCutting{
    static int max=0;
    public static void Main(){
        int waste=int.Parse(Console.ReadLine());
        int[] wood={1,2,3,4,5,6,7,8,9,10,11,12};
        int[] price={1,5,8,9,10,17,17,20,22,22,25,26};
        Combination(wood,0,0,price,waste);
        Console.WriteLine(max);
    }
    public static void Combination(int[] wood, int length,int sum, int[] price,int waste){
        if(length==(wood.Length-waste)){
            if(sum>max){
                max=sum;
            }
            return;
        }
        if(length>(wood.Length-waste)) return;
        for(int i=0;i<(wood.Length-waste);i++){
            Combination(wood,length+wood[i],sum+price[i],price,waste);
        }
    }
}