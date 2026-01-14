using System;
using System.Text;
using System.Collections.Generic;
class RemoveDuplicate{
    public static void Main(){
        StringBuilder sb=new StringBuilder(Console.ReadLine());
        Dictionary<char, int> map = new Dictionary<char,int>();
        for(int i=0;i<sb.Length;i++){
            if(!map.ContainsKey(sb[i])) map.Add(sb[i],i);
        }
        for(int i=0;i<sb.Length;i++){
            if(map[sb[i]]!=i) sb.Remove(i,1);
        }
        Console.WriteLine(sb.ToString());
    }
}