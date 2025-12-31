using System;
class MultiplicationTableFrom6To9{
    static void Main(){
        int[] arr=new int[4];
        // taking a number as an input
        Console.WriteLine("enter a number : ");
        int n=int.Parse(Console.ReadLine());
        int idx=6;
        for(int i=0;i<4;i++){
            arr[i]=n*idx;
            idx++;
        }
        idx=6;
        for(int i=0;i<4;i++){
            Console.WriteLine(n+" * "+idx+" = "+arr[i]);
            idx++;
        }
    }
}
