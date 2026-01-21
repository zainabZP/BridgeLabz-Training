using System;
class ReverseList{
    public static void Main(){
        List<int> li=new List<int>();
        Console.WriteLine("enter number of list elements : ");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine("enter "+n+" elements : ");
        for(int k=0;k<n;k++){
            li.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine(string.Join(", ", li));
        int i=0,j=li.Count-1;
        while(i<j){
            int t=li[i];
            li[i]=li[j];
            li[j]=t;
            i++;j--;
        }
        Console.WriteLine(string.Join(", ", li));
    }
}