using System;
class NumberChecker{
    public static int CountDigits(int n){
        int c=0;
        while(n>0){
            c++;
            n=n/10;
        }
        return c;
    }
    public static int[] Store(int size, int n){
        int[] a=new int[size];
        int i=0;
        while(n>0){
            int temp=n%10;
            a[i]=temp;
            i++;
            n=n/10;
        }
        return a;
    }
    public static int Sum(int[] a){
        int sum=0;
        for(int i=0;i<a.Length;i++){
            sum+=a[i];
        }
        return sum;
    }
    public static int Pow(int[] a){
        int powSum=0;
        for(int i=0;i<a.Length;i++){
            powSum+=(a[i]*a[i]);
        }
        return powSum;
    }
    public static bool Harshad(int n){
        int ogNumber=n;
        int sum=0;
        while (n!=0){
			int t=n%10;
            sum=sum+t;
            n=n/10;
        }
        if (ogNumber%sum==0) return true;
        else return false;
    }
    public static void Frequency(int[] f){
        Array.Sort(f);
        int count=1;
        for(int i=0;i<f.Length-1;i++){
            if(f[i]==f[i+1]) count++;
            else{
                Console.WriteLine("frequency of "+f[i]+" = "+count);
                count=1;
            }
        }
        Console.WriteLine("frequency of "+f[f.Length-1]+" = "+count);
    }
    static void Main(){
        Console.WriteLine("enter a number : ");
        int n=int.Parse(Console.ReadLine());
        int size=CountDigits(n);
        int[] arr=Store(size,n);
        Console.WriteLine("Sum of digits = "+Sum(arr));
        Console.WriteLine("Sum of squares of digits = "+Pow(arr));
        if(Harshad(n)) Console.WriteLine("It is a Harshad number");
        else Console.WriteLine("It is not a Harshad number");
        Console.WriteLine("Digit frequencies:");
        Frequency(arr);
    }
}