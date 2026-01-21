using System;
class RotateList{
    public static void Main(){
        List<int> li=new List<int>();
        Console.WriteLine("enter number of list elements : ");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine("enter rotate value : ");
        int m=int.Parse(Console.ReadLine());
        Console.WriteLine("enter "+n+" elements : ");
        for(int k=0;k<n;k++){
            li.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine(string.Join(", ", li));
        int size=li.Count;
        int i=0,j=size-1;
        while(i<j){
             int t=li[i];
            li[i]=li[j];
            li[j]=t;
            i++;j--;
        }
        i=0;j=size-m-1;
        while(i<j){
             int t=li[i];
            li[i]=li[j];
            li[j]=t;
            i++;j--;
        }
        i=size-m;j=size-1;
        while(i<j){
             int t=li[i];
            li[i]=li[j];
            li[j]=t;
            i++;j--;
        }
        Console.WriteLine(string.Join(", ", li));
    }
}