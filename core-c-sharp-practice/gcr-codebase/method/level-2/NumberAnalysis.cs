using System;
class NumberCheck{
    static void Main(){
        int[] a=new int[5];

        for(int i=0;i<5;i++){
            Console.Write("Enter number: ");
            a[i]=int.Parse(Console.ReadLine());

            if(Positive(a[i])){
                if(Even(a[i])) Console.WriteLine("Positive Even");
                else Console.WriteLine("Positive Odd");
            }
            else{
                Console.WriteLine("Negative");
            }
        }

        int r=Compare(a[0],a[4]);
        Console.WriteLine("Comparison Result = "+r);
    }

    static bool Positive(int n){
        if(n>=0) return true;
        else return false;
    }

    static bool Even(int n){
        if(n%2==0) return true;
        else return false;
    }

    static int Compare(int x,int y){
        if(x>y) return 1;
        else if(x==y) return 0;
        else return -1;
    }
}
