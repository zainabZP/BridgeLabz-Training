using System;
class ReverseList{
    public static void Main(){
        List<string> li=new List<string>();
        Console.WriteLine("enter number of list elements : ");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine("enter "+n+" elements : ");
        for(int k=0;k<n;k++){
            li.Add(Console.ReadLine());
        }
        Console.WriteLine(string.Join(", ", li));
        Dictionary<string,int> map=new Dictionary<string,int>();
        for(int i=0;i<n;i++){
            if(!map.ContainsKey(li[i]))
                map.Add(li[i],1);
            else{
                map[li[i]]=map[li[i]]+1;
            }
        }
        foreach(string key in map.Keys){
            Console.WriteLine(key + " = " + map[key]);
        }
    }
}