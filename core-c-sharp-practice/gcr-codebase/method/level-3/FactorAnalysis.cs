using System;
class Factors{
    public static int CountFactors(int n){
        int c=0;
        for(int i=1;i<=n;i++){
            if(n%i==0){
                c++;
            }
        }
        return c;
    }
    public static int[] FactorsArray(int n){
        int size=CountFactors(n);
        int[] a=new int[size];
        int idx=0;
        for(int i=1;i<=n;i++){
            if(n%i==0){
                a[idx]=i;
                idx++;
            }
        }
        return a;
    }
    public static int LargestFactor(int n){
         int[] arr=FactorsArray(n);
         Array.Sort(arr);
         return arr[arr.Length-1];
    }
    public static int Product(int n){
        int[] arr=FactorsArray(n);
        int pro=1;
        for(int i=0;i<arr.Length;i++){
            pro*=arr[i];
        }
        return pro;
    }
    public static int CubeProduct(int n){
        int[] arr=FactorsArray(n);
        int pro=1;
        for(int i=0;i<arr.Length;i++){
            pro*=(int)Math.Pow(arr[i],3);
        }
        return pro;
    }
    public static int Add(int n){
        int[] arr=FactorsArray(n);
        int sum=0;
        for(int i=0;i<arr.Length;i++){
            sum+=arr[i];
        }
        return sum;
    }
    public static bool Perfect(int n){
        int sum=Add(n)-n;
        if(sum==n) return true;
        else return false;
    }
    public static bool Abundant(int n){
        int sum=Add(n)-n;
        if(sum>n) return true;
        else return false;
    }
    public static bool Deficient(int n){
        int sum=Add(n)-n;
        if(sum<n) return true;
        else return false;
    }
    static void Main(){
        Console.WriteLine("enter a number : ");
        int n=int.Parse(Console.ReadLine());
        int[] arr=FactorsArray(n);                               
        Console.WriteLine("factors are : ");                         
        for(int i=0;i<arr.Length;i++){                            
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine("largest factor = "+LargestFactor(n));     
        Console.WriteLine("product of factors = "+Product(n));       
        Console.WriteLine("cube product of factors = "+CubeProduct(n)); 
        Console.WriteLine("sum of factors = "+Add(n));               
        if(Perfect(n)) Console.WriteLine("It is a perfect number"); 
        int(Abundant(n)) Console.WriteLine("It is a Abundant number");
        if(Deficient(n)) Console.WriteLine("It is a deficient number");
    }
}
