using System;
class SumOfNumbers{
    static void Main(){
        int[] arr=new int[10];
        int sum=0,idx=0;
        // taking a number as an input
        Console.WriteLine("enter a number : ");
        int n=int.Parse(Console.ReadLine());
        while(n>0&&idx<10){
            arr[idx]=n;
            idx++;
            Console.WriteLine("again enter a number : ");
            n=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<10;i++){
            sum+=arr[i];
        }
        Console.WriteLine("sum= "+sum);
    }
}
