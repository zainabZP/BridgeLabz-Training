using System;
class CheckNumbers{
    static void Main(){
        int[] arr=new int[5];
        // taking age as an input
        Console.WriteLine("enter 5 numbers : ");
        for(int i=0;i<5;i++)
        arr[i]=int.Parse(Console.ReadLine());
        // check if age is equal or greater than 18, if yes than eligible else not
        for(int i=0;i<5;i++){
            if (arr[i]>0){
                if(arr[i]%2==0) Console.WriteLine("number "+arr[i]+", is positive and even");
                else Console.WriteLine("number "+arr[i]+", is positive and odd");
            }
            else if(arr[i]<0)
                Console.WriteLine("number "+arr[i]+", is negative");
            else
                Console.WriteLine("number "+arr[i]+", is zero");
        }
        if(arr[0]==arr[4]) Console.WriteLine("first and last number of array are equal");
        else if(arr[0]>arr[4]) Console.WriteLine("first number is greater than last number of array");
        else if(arr[0]>arr[4]) Console.WriteLine("last number is greater than first number of array");
    }
}
