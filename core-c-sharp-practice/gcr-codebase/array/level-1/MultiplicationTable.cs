using System;
class MultiplicationTable{
    static void Main(){
        int[] arr=new int[10];
        // taking a number as an input
        Console.WriteLine("enter a number : ");
        int n=int.Parse(Console.ReadLine());
        for(int i=0;i<10;i++)
        arr[i]=n*(i+1);
        for(int i=0;i<10;i++)
        Console.WriteLine(n+" * "+(i+1)+" = "+arr[i]);
    }
}
