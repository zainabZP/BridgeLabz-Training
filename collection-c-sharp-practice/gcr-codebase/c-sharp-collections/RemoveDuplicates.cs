using System;
class RemoveDuplicates{
    public static void Main(){
        List<int> li=new List<int>();
        Console.WriteLine("enter number of list elements : ");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine("enter "+n+" elements : ");
        for(int k=0;k<n;k++){
            li.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine(string.Join(", ", li));
        List<int> newList=new List<int>();
        for(int k=0;k<n;k++){
            if(!newList.Contains(li[k]))
            newList.Add(li[k]);
        }
        Console.WriteLine(string.Join(", ", newList));
    }
}