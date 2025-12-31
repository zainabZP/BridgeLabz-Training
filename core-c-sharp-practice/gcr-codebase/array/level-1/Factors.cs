using System;
class Factors{
    static void Main(){
        Console.WriteLine("enter number : ");
        int n=int.Parse(Console.ReadLine());
        int c=0;
        for(int i=1;i<=n;i++){
            if(n%i==0) c++;
        }
        int[] factors=new int[c];
        int idx=0;
        for(int i=1;i<=n;i++){
            if(n%i==0){
                factors[idx]=i;
                idx++;
            }
        }
        Console.WriteLine("factors are : ");
        for(int i=0;i<factors.Length;i++){
            Console.WriteLine(factors[i]);
        }
    }
}
