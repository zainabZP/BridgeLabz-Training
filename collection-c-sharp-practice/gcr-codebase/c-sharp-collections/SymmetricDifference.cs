using System;
class SymmetricDifference{
    public static void Main(){
        HashSet<int> set1 = new HashSet<int>();
        int n1=int.Parse(Console.ReadLine());
        for(int i=0;i<n1;i++){
            set1.Add(int.Parse(Console.ReadLine()));
        }
        HashSet<int> set2 = new HashSet<int>();
        int n2=int.Parse(Console.ReadLine());
        for(int i=0;i<n2;i++){
            set2.Add(int.Parse(Console.ReadLine()));
        }
        HashSet<int> diff = new HashSet<int>();
        foreach(int i in set1){
            if(!set2.Contains(i))
            diff.Add(i);
        }
        foreach(int i in set2){
            if(!set1.Contains(i))
            diff.Add(i);
        }
        foreach(int i in diff){
            Console.Write(i+" ");
        }
    }
}