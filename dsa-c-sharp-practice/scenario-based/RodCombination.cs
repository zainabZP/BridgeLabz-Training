using System;
class RodCutting{
    static int max=0;
    public static void Main(){
        int[] rod={1,2,3,4,5,6,7,8};
        int[] price={1,5,8,9,10,17,17,20};
        Combination(rod,0,0,price);
        Console.WriteLine(max);
    }
    public static void Combination(int[] rod, int length,int sum, int[] price){
        if(length==rod.Length){
            if(sum>max){
                max=sum;
            }
            return;
        }
        if(length>rod.Length) return;
        for(int i=0;i<rod.Length;i++){
            Combination(rod,length+rod[i],sum+price[i],price);
        }
    }
}