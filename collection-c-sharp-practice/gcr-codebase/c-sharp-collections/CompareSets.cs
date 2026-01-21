using System;
class CompareSets{
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
        if(set1.Count!=set2.Count){
            Console.WriteLine("Not equal");
        }
        else{
            bool f=true;
            foreach(int i in set1){
                if(!set2.Contains(i)){
                    f=false;break;
                }
            }
            if(f) Console.WriteLine("Equal");
            else Console.WriteLine("Not Equal");
        }
    }
}